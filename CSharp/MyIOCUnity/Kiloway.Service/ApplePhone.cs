using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiloway.Interface;
using Unity;
using Unity.Attributes;

namespace Kiloway.Service
{
    public class ApplePhone : IPhone
    {
        [Dependency]
        public IMicro micro { get; set; }
        public IHead head;
        public IPower power { get; set; }

        public ApplePhone()
        {

        }
        [InjectionConstructor]
        public ApplePhone(IHead head)
        {
            this.head = head;
            Console.WriteLine("ApplePhone(IHead head)");
        }


        public void Call()
        {
            Console.WriteLine("Call {0}", this.GetType().Name);
        }

        public void System()
        {
            Console.WriteLine("IOS System {0}", this.GetType().Name);
        }

        [InjectionMethod]
        public void INIT(IPower power)
        {
            this.power = power;
        }
    }
}
