using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAbstract.Abstract;
using MyAbstract.Service;

namespace MyAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("****************************************");
                {
                    Abstract.AbstractPhone phone = new ApplePhone();
                    phone.System();
                    phone.Call();
                }
                {

                    Abstract.AbstractPhone phone = new P10();
                    phone.System();
                    phone.Call();

                    dynamic dyn_phone = phone;
                    dyn_phone.System();
                    dyn_phone.Movie();
                    dyn_phone.Price = 19;
                    Console.WriteLine("Price:{0}", dyn_phone.Price);
                }
                Console.WriteLine();
                Console.WriteLine("****************************************");
                {
                    IExtend extend = new ApplePhone();
                    extend.Movie();
                    extend.Price = 19;
                    Console.WriteLine("Price:{0}", extend.Price);
                }

                {

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
