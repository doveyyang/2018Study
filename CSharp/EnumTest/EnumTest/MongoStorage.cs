using Kiloway.FileStorage.FileStorageInterface;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    /// <summary>
    /// MongoDB文件存储类
    /// by:Jay
    /// </summary>
    public class MongoStorage : IFileStorage
    {
        private string connectionString = "mongodb://192.168.0.147:27017";
        MongoClient mongoClient;
        IMongoDatabase db;

        private FileStorageContext context;

        public MongoStorage(FileStorageContext context)
        {
            this.context = context;
            connectionString = context.GetConfig("mongoConnectionString") ?? connectionString;
            mongoClient = new MongoClient(connectionString);
            db = mongoClient.GetDatabase("MongoFileSystem");
        }

        public Stream GetFileStream(string filePath)
        {
            string[] stringArray = filePath.Split('\\');
            if (stringArray.Length < 2)
                new FileUtilsException($"文件路径不正确:{filePath}");
            GridFSBucket fileSystem = new GridFSBucket(db, new GridFSBucketOptions { BucketName = stringArray[0] });
            string fileName = filePath.Substring(stringArray[0].Length + 1, filePath.Length - stringArray[0].Length - 1);
            byte[] bytes = fileSystem.DownloadAsBytesByName(fileName);
            MemoryStream ms = new MemoryStream(bytes);
            return ms;
        }

        public string GetStoragePath(string bucketName, string filename)
        {
            return $"{bucketName}\\{filename}";
        }

        public string StorageFile(Stream fileStream, string filePath)
        {
            string[] stringArray = filePath.Split('\\');
            if (stringArray.Length < 2)
                new FileUtilsException($"文件路径不正确:{filePath}");
            GridFSBucket fileSystem = new GridFSBucket(db, new GridFSBucketOptions { BucketName = stringArray[0] });
            string fileName = filePath.Substring(stringArray[0].Length + 1, filePath.Length - stringArray[0].Length - 1);
            fileSystem.UploadFromStream(fileName, fileStream);
            return filePath;
        }

        public bool Exist(string filePath)
        {
            string[] stringArray = filePath.Split('\\');
            if (stringArray.Length < 2)
                new FileUtilsException($"文件路径不正确:{filePath}");
            GridFSBucket fileSystem = new GridFSBucket(db, new GridFSBucketOptions { BucketName = stringArray[0] });
            string fileName = filePath.Substring(stringArray[0].Length + 1, filePath.Length - stringArray[0].Length - 1);

            var filter = Builders<GridFSFileInfo>.Filter.Eq(x => x.Filename, fileName);
            using (var cursor = fileSystem.Find(filter))
            {
                var fileInfo = cursor.ToList();
                return fileInfo.Count != 0;
            }
        }


        public void Delete(string filePath)
        {
            string[] stringArray = filePath.Split('\\');
            if (stringArray.Length < 2)
                new FileUtilsException($"文件路径不正确:{filePath}");
            GridFSBucket fileSystem = new GridFSBucket(db, new GridFSBucketOptions { BucketName = stringArray[0] });
            string fileName = filePath.Substring(stringArray[0].Length + 1, filePath.Length - stringArray[0].Length - 1);

            fileSystem.Delete(fileName);
        }
    }
}
