using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbstract.Abstract
{
    public abstract class AbstractPhone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        protected int _price;
        public abstract void System();
        public void Call()
        {
            Console.WriteLine("Call- {0}",this.GetType().Name);
        }
        public void Text() {
            Console.WriteLine("Text - {0}",this.GetType().Name);
        }
    }
}
