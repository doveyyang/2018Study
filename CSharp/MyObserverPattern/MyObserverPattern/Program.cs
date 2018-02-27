using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyObserverPattern.Object;
using MyObserverPattern.ObServer;

namespace MyObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("---------------------------");

                Cat cat = new Cat();
                cat.Miao();


                Console.WriteLine("---------------------------");
                cat.addObserver(new Dog());
                cat.addObserver(new Chindren());                
                cat.addObserver(new Mother());
                cat.addObserver(new Father());
                cat.MiaoObserver();

                Console.WriteLine("---------------------------");
                cat.eventHandler += new Dog().Bark;
                cat.eventHandler += new Chindren().Cry;
                cat.eventHandler += new Mother().Stand;
                cat.eventHandler += new Father().Run;
                cat.MiaoEvent();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
