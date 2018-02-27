using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    /// <summary>
    /// 文件存储上下文
    /// by:Jay
    /// </summary>
    public class FileStorageContext
    {
        private Dictionary<string, string> configMap = new Dictionary<string, string>();
        public string GetConfig(string key)
        {
            if (configMap.ContainsKey(key))
                return configMap[key];
            else
                return null;
        }

        public void SetConfig(string key, string value)
        {
            configMap[key] = value;
        }
    }
}
