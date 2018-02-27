using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyCache
{
    /// <summary>
    /// 缓存的工具类
    /// </summary>
    public class CustomCache
    {
        /// <summary>
        /// 私有化是为了安全，静态是为了常驻内存，Dictionary保存多个key value pair 键值对
        /// </summary>
        private static Dictionary<string, KeyValuePair<object,DateTime>> customCacheDictionary = new Dictionary<string, KeyValuePair<object, DateTime>>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="minute">默认30分钟</param>
        private static void Add(string key,object value,int minute = 30)
        {
            customCacheDictionary[key] = new KeyValuePair<object, DateTime>(value,DateTime.Now.AddMinutes(minute));
        }

        private static T Get<T>(string key)
        {
            return (T)customCacheDictionary[key].Key;
        }

        private static bool Contains(string key)
        {
            if (customCacheDictionary.ContainsKey(key))
            {
                var kvPair = customCacheDictionary[key];
                if (kvPair.Value > DateTime.Now)
                {
                    return true;
                }
                else
                {
                    customCacheDictionary.Remove(key);
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Func
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static T GetDate<T> (string key,Func<T> func,int minute)
        {
            T result = default(T);
            if (CustomCache.Contains(key))
            {
                result = CustomCache.Get<T>(key);
            }
            else
            {
                result = func.Invoke();//DataSource.Count(key);
                CustomCache.Add(key, result,minute);
            }
            return result;
        }
        public static void Remove(string key)
        {
            customCacheDictionary.Remove(key);
        }
        //
        public static void RemoveAll()
        {
            customCacheDictionary.Clear();
            customCacheDictionary =new Dictionary<string, KeyValuePair<object, DateTime>>();
        }

        static CustomCache()
        {
            //主动清理
            Task.Run(()=>
            {
                while(true)
                {
                    if (customCacheDictionary != null && customCacheDictionary.Count > 0)
                    {
                        List<string> keyList = new List<string>();
                        foreach (var key in customCacheDictionary.Keys)
                        {
                            if (customCacheDictionary[key].Value <= DateTime.Now)
                            {
                                customCacheDictionary.Remove(key);
                            }
                        }
                        keyList.ForEach(k=>customCacheDictionary.Remove(k));
                    }
                    Thread.Sleep(3000);
                }
            });
        }
            
    }
}
