using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Interface
{
    public abstract class BaseVocalImitation
    {
        private object lockObj = new object();
        public delegate void OnFireAction();
        public event OnFireAction FireEvents;

        protected int Temperature { get; set; } = 400;
        protected bool IsFired { get; set; } = false;
        public string Person { get; set; }
        public string Table { get; set; }
        public string Chair { get; set; }
        public string Fan { get; set; }
        public string Ruler { get; set; }

        public abstract void DogBark();
        public abstract void Say();
        public abstract void Wind();

        public void StartAction()
        {
            //Console.WriteLine("Start Action...");
            Helper.Out2ConsoleAndFile("Start Action...");
        }
        public virtual void BeginAction()
        {
            Helper.Out2ConsoleAndFile("Begin Action...");
        }
        public virtual void EndAction()
        {
            Helper.Out2ConsoleAndFile("End Action...");
        }

        public void OnFireStart(int temperature)
        {
            if (!this.IsFired)
            {
                lock (lockObj)
                {
                    if (temperature >= this.Temperature&& !this.IsFired)
                    {
                        Helper.Out2ConsoleAndFile("Name :" + this.GetType().Name);
                        
                        this.StartAction();
                        this.BeginAction();
                        this.FireEvents.Invoke();
                        this.EndAction();
                        this.IsFired = true;

                        Helper.Out2ConsoleAndFile("----------------------------");
                    }
                }
            }
           
        }
    }
}
