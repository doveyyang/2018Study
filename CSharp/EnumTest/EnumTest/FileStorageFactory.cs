using System;
using System.Configuration;
using System.Reflection;

namespace EnumTest
{
    /// <summary>
    /// 文件存储工厂
    /// by:Jay
    /// </summary>
    public class FileStorageFactory
    {
        private string configPath;
        private FileStorageFactory(string configPath = null)
        {
            if (string.IsNullOrEmpty(configPath))
                this.configPath = AppDomain.CurrentDomain.BaseDirectory + "filestorage.config";
            else
                this.configPath = configPath;
        }

        private static IFileStorage storageInstance = null;
        public static IFileStorage GetStorage()
        {
            if(storageInstance == null)
            {
                storageInstance = new FileStorageFactory().CreateStorage();
            }

            return storageInstance;
        }

        /// <summary>
        /// 读取配置文件获取文件存储上下文
        /// </summary>
        /// <returns></returns>
        private FileStorageContext GetContext()
        {
            FileStorageContext context = new FileStorageContext();
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            fileMap.ExeConfigFilename = configPath;

            Configuration configuration = ConfigurationManager
                .OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            foreach (var key in configuration.AppSettings.Settings.AllKeys)
            {
                context.SetConfig(key, configuration.AppSettings.Settings[key].Value);
            }
            return context;
        }

        IFileStorage CreateStorage()
        {
            FileStorageContext context = GetContext();
            string assemblyName = context.GetConfig("storageDriver.assembly");
            string typeName = context.GetConfig("storageDriver.type");
            Assembly assembly = Assembly.Load(assemblyName);
            
            IFileStorage storage = (IFileStorage)assembly
                .CreateInstance(typeName, true, BindingFlags.Default, null
                , new object[] { context }, null, null);
            return storage;
        }
    }
}
