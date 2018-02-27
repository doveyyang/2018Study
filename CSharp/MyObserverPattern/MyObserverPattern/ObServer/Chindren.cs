using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserverPattern.ObServer
{
   public class Chindren : IObserver
    {
        public void Action()
        {
            this.Cry();
        }
        public void Cry()
        {
            Console.WriteLine("Cry...{0}", this.GetType().Name);
        }
    }
}
