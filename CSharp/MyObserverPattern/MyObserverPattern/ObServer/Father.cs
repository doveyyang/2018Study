using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserverPattern.ObServer
{
    public class Father : IObserver
    {
        public void Action()
        {
            this.Run();
        }
        public void Run()
        {
            Console.WriteLine("Run...{0}", this.GetType().Name);
        }
    }
}
