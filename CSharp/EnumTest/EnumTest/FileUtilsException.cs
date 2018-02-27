using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiloway.FileStorage.FileStorageInterface
{
    /// <summary>
    /// 文件存储异常类
    /// by:Jay
    /// </summary>
    public class FileUtilsException : Exception
    {
        public FileUtilsException(string innerText) : base(innerText)
        {
        }
    }
}
