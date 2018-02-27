using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserverPattern.ObServer
{
    public class Dog : IObserver
    {
        public void Action()
        {
            this.Bark();
        }
        public void Bark() {
            Console.WriteLine("Bark...{0}", this.GetType().Name);
        }
    }
}
