using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAbstract.Abstract;

namespace MyAbstract.Service
{
    public class ApplePhone : AbstractPhone, IExtend
    {
        public int this[int index] { get => index; set => index = value; }

        public int Price { get => this._price; set => _price = value; }

        public event Action DoEvent;

        public void Movie()
        {
            Console.WriteLine("Movie - {0}", this.GetType().Name);
        }
                
        public override void System()
        {
            Console.WriteLine("IOS System - {0}", this.GetType().Name);
        }
    }
}
