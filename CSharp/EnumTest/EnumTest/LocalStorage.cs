using Kiloway.FileStorage.FileStorageInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    /// <summary>
    /// 磁盘文件存储类
    /// by:Jay
    /// </summary>
    public class LocalStorage : IFileStorage
    {

        /// <summary>
        /// 配置信息上下文
        /// </summary>
        private string rootDir = @"d:\apofco\";
        private string rootName = @"\\LOCAL-ROOT\\";

        private FileStorageContext context;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="context"></param>
        public LocalStorage(FileStorageContext context)
        {
            this.context = context;
            rootDir = context.GetConfig("localRootDirectory") ?? rootDir;
            if (!rootDir.EndsWith("\\"))
            {
                rootDir = rootDir + "\\";
            }
        }
        /// <summary>
        /// 创建路径
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        private string CreateDirectory(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            return dir;
        }
        /// <summary>
        /// 返回路径
        /// </summary>
        /// <param name="bucket"></param>
        /// <returns></returns>
        private string GetBucketDirectory(string bucket)
        {
            return CreateDirectory(rootDir + $"{bucket}\\");
        }
        /// <summary>
        /// 返回文件存储的路径
        /// </summary>
        /// <param name="bucket"></param>
        /// <param name="fileName"></param>
        /// <param name="ext"></param>
        /// <returns></returns>
        public string GetStoragePath(string bucket, string fileName)
        {
            string path = CreateDirectory(GetBucketDirectory(bucket)) + "\\" + fileName;
            return path.Replace(rootDir, rootName);
        }
        /// <summary>
        /// 存储文件
        /// </summary>
        /// <param name="fileStream"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public string StorageFile(Stream fileStream, string filePath)
        {
            filePath = filePath.Replace(rootName, rootDir);
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
            fileStream.CopyTo(fs);
            fs.Flush();
            fs.Close();
            return filePath;
        }
        /// <summary>
        /// 返回流
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public Stream GetFileStream(string filePath)
        {
            filePath = filePath.Replace(rootName, rootDir);
            FileStream fs = new FileStream(filePath, FileMode.Open);
            return fs;
        }

        /// <summary>
        /// 判断文件是否存在
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public bool Exist(string filePath)
        {
            filePath = filePath.Replace(rootName, rootDir);
            return File.Exists(filePath);
        }
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="filePath"></param>
        public void Delete(string filePath)
        {
            filePath = filePath.Replace(rootName, rootDir);
            File.Delete(filePath);
        }
    }
}
