using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserverPattern.ObServer
{
    public class Mother:IObserver
    {
        public void Action()
        {
            this.Stand();
        }

        public void Stand()
        {
            Console.WriteLine("Stand...{0}", this.GetType().Name);
        }
    }
}
