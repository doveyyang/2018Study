using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyCache
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region 0124
                //for (int i = 0; i < 5; i++)
                //{
                //    string key = $"DataSource_Count_123";
                //    int result = 0;

                //   result = CustomCache.GetDate<int>(key,() => DataSource.Count(123));

                //    //if (CustomCache.Contains(key))
                //    //{
                //    //    result = CustomCache.Get<int>(key);
                //    //}
                //    //else
                //    //{
                //    //    result = DataSource.Count(234);
                //    //    CustomCache.Add(key,result);
                //    //}
                //    Console.WriteLine($"{i} - {result}");
                //}

                //for (int i = 0; i < 5; i++)
                //{
                //    //Console.WriteLine($"{i} - {DataSource.Count(234)}");
                //    string key = $"DataSource_Count_234";
                //    int result = 0;
                //    result = CustomCache.GetDate<int>(key, () => DataSource.Count(234));
                //    //if (CustomCache.Contains(key))
                //    //{
                //    //    result = CustomCache.Get<int>(key);
                //    //}
                //    //else
                //    //{
                //    //    result = DataSource.Count(234);
                //    //    CustomCache.Add(key, result);
                //    //}
                //    Console.WriteLine($"{i} - {result}");
                //}
                #endregion

                #region 0125
                //for (int i = 0; i < 5; i++)
                {
                    string key = $"DataSource_Count_123";
                    int result = 0;

                    result = CustomCache.GetDate<int>(key, () => DataSource.Count(123),1);
                    
                    Console.WriteLine($" {result}");

                    CustomCache.Remove(key);
                    CustomCache.RemoveAll();

                   // result = CustomCache.GetDate<int>(key, () => DataSource.Count(123),1);

                    result = CustomCache.GetDate<int>(key, () => DataSource.Count(123), 1);

                    Thread.Sleep(70000);

                    result = CustomCache.GetDate<int>(key, () => DataSource.Count(123), 1);
                }
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            Console.ReadKey();
        }
    }
}
