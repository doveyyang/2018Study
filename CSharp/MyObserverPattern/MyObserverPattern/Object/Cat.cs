using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyObserverPattern.ObServer;

namespace MyObserverPattern.Object
{
    public class Cat
    {
        public void Miao()
        {
            Console.WriteLine("****************Common**************************");
            Console.WriteLine("Miao...{0}", this.GetType().Name);

            new Dog().Bark();
            
            new Mother().Stand();
            new Father().Run();
            new Chindren().Cry();
        }
      
        private List<IObserver> _observerlist = new List<IObserver>();
        public void addObserver(IObserver observer)
        {
            this._observerlist.Add(observer);
        }

        public void MiaoObserver()
        {
            Console.WriteLine("****************MiaoObserver**************************");
            Console.WriteLine("MiaoObserver...{0}", this.GetType().Name);
            if (this._observerlist != null && this._observerlist.Count > 0)
            {
                foreach (var observer in this._observerlist)
                {
                    observer.Action();
                }
            }
        }

        public event Action eventHandler;

        public void MiaoEvent()
        {
            Console.WriteLine("****************MiaoEvent**************************");
            Console.WriteLine("MiaoEvent...{0}", this.GetType().Name);
            if (eventHandler!=null)
            {
                foreach (Action handler in eventHandler.GetInvocationList())
                {
                    handler.Invoke();
                }
            }
        }
    }
}
