using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIOCUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("-----------------");
                IOCTest ioc = new IOCTest();

                ioc.Show();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            Console.Read();
        }
    }
}
