using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    /// <summary>
    /// 文件存储接口类
    /// by:Jay
    /// </summary>
    public interface IFileStorage
    {
        /// <summary>
        /// 获取存储路径
        /// </summary>
        /// <param name="bucketName">文件类型</param>
        /// <param name="fileName">文件ID</param>
        /// <param name="ext">扩展名</param>
        /// <returns>存储路径</returns>
        string GetStoragePath(string bucketName, string fileName);
        /// <summary>
        /// 存储一个文件到mongodb
        /// </summary>
        /// <param name="fileStream">文件流</param>
        /// <param name="filePath">文件存储路径</param>
        /// <returns>文件存储路径</returns>
        string StorageFile(Stream fileStream, string filePath);
        /// <summary>
        /// 从mongodb中读取一个文件
        /// </summary>
        /// <param name="filePath">文件名</param>
        /// <returns>文件流</returns>
        Stream GetFileStream(string filePath);
        /// <summary>
        /// 判断文件是否存在 
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns>存在状态</returns>
        bool Exist(string filePath);
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        void Delete(string filePath);
    }
}
