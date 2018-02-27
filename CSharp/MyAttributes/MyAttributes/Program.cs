using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAttributes.AOP;

namespace MyAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Commodity commodity = new Commodity() {
                    Id = 1,
                    Name = "Computer",
                    Number = 1001,
                    Price = 11,
                    Url = "https://www.2345.com/?37698-0027"
                };

                BaseDAL.Insert<Commodity>(commodity);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
