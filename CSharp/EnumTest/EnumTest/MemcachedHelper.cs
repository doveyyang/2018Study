using Memcached.ClientLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace EnumTest
{
    public class MemcachedHelper
    {
        private static MemcachedClient mclient;
        private static string configPath = AppDomain.CurrentDomain.BaseDirectory + "memcache.config";
        static MemcachedHelper()
        {
            try
            {
                ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
                fileMap.ExeConfigFilename = configPath;

                Configuration configuration = ConfigurationManager
                    .OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
                if (configuration == null || configuration.AppSettings==null||configuration.AppSettings==null)
                    throw new Exception("未找到Memcahce配置文件，请先配置文件");

                string server = configuration.AppSettings.Settings["serverList"].Value;
                string[] serverList = { server };
                // 初始化SocketIO池
                string poolName = configuration.AppSettings.Settings["poolName"].Value;//"MemcachedPool";
                SockIOPool sockIOPool = SockIOPool.GetInstance(poolName);
                // 添加服务器列表
                sockIOPool.SetServers(serverList);
                // 设置连接池初始数目
                sockIOPool.InitConnections = int.Parse(configuration.AppSettings.Settings["InitConnections"].Value);//10;
                // 设置连接池最小连接数目
                sockIOPool.MinConnections = int.Parse(configuration.AppSettings.Settings["MinConnections"].Value);//10;
                // 设置连接池最大连接数目
                sockIOPool.MaxConnections = int.Parse(configuration.AppSettings.Settings["MaxConnections"].Value);//200;
                // 设置连接的套接字超时时间（单位：毫秒）
                sockIOPool.SocketConnectTimeout = int.Parse(configuration.AppSettings.Settings["SocketConnectTimeout"].Value);// 2000;
                // 设置套接字超时时间（单位：毫秒）
                sockIOPool.SocketTimeout = int.Parse(configuration.AppSettings.Settings["SocketTimeout"].Value);// 4000;
                // 设置维护线程运行的睡眠时间：如果设置为0，那么维护线程将不会启动
                sockIOPool.MaintenanceSleep = int.Parse(configuration.AppSettings.Settings["MaintenanceSleep"].Value);//30;
                // 设置SockIO池的故障标志
                sockIOPool.Failover = configuration.AppSettings.Settings["Failover"].Value.Equals("true")?true:false;//true;
                // 是否用nagle算法启动
                sockIOPool.Nagle = configuration.AppSettings.Settings["Nagle"].Value.Equals("true") ? true : false;//false;
                // 正式初始化容器
                sockIOPool.Initialize();

                mclient = new MemcachedClient();
                mclient.PoolName = poolName;
                mclient.EnableCompression = configuration.AppSettings.Settings["EnableCompression"].Value.Equals("true") ? true : false;//false;
                mclient.FlushAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获得缓存数据
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static object GetCache(string key)
        {
            return mclient.Get(key);
        }

        /// <summary>
        /// 获取缓存数据集
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public static object[] GetCache(string[] keys)
        {
            return mclient.GetMultipleArray(keys);
        }

        /// <summary>
        /// 设置缓存数据
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <param name="expiry">过期时间</param>
        /// <returns></returns>
        public static bool SetCache(string key, object value, DateTime? expiry = null)
        {
            if (expiry == null)
            {
                return mclient.Set(key, value);
            }
            return mclient.Set(key, value, expiry.Value);
        }

        /// <summary>
        /// 删除指定缓存
        /// </summary>
        /// <param name="key"></param>
        public static void RemoveCache(string key)
        {
            if (mclient.KeyExists(key))
                mclient.Delete(key);
        }

        /// <summary>
        /// 删除所有缓存
        /// </summary>
        public static void RemoveCacheAll()
        {
            mclient.FlushAll();
        }

        /// <summary>
        /// 判断此缓存是否有效
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool HasCache(string key)
        {
            return mclient.KeyExists(key);
        }
    }
}
