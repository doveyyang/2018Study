using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttributes.AOP
{
   public abstract class AbstractAttribute:Attribute
    {
        public abstract bool Vaildate(object t);
    }
}
