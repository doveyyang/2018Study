using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Apache.NMS;

namespace KilowaySDK.ActiveMQ.Interface
{
    /// <summary>
    /// 数据传输模型
    /// </summary>
    [Serializable]
    public class BaseMessage
    {
        /// <summary>
        /// 属性
        /// </summary>
        public virtual string Opeation { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public virtual string Result { get; set; }
    }



    /// <summary>
    /// 扩展方法类
    /// </summary>
    public static class ExtendMethods
    {
        /// <summary>
        /// 将对象转换为bytes
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bytes</returns>
        public static byte[] ToBytes<T>(this T obj) where T : class
        {
            if (obj == null)
                return null;
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                return ms.GetBuffer();
            }
        }

        /// <summary>
        /// 将bytes转换为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static T ToObject<T>(this byte[] bytes) where T : class
        {
            if (bytes == null)
                return default(T);
            using (var ms = new MemoryStream(bytes))
            {
                var formatter = new BinaryFormatter();
                return formatter.Deserialize(ms) as T;
            }
        }
    }
}
