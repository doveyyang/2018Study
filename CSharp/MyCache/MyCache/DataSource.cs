using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCache
{
    public class DataSource
    {
        public static int Count(int k)
        {
            int result = 0;
            for (int i = k; i < 1000000; i++)
            {
                result += k;
            }
            Console.WriteLine($"compute Count");
            return result;
        }
    }
}
