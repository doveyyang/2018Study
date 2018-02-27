using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttributes.AOP
{
    public class LengthAttribute : Attribute
    {
        private int _Max = 0;
        public LengthAttribute(int max)
        {
            this._Max = max;
        }
        public bool Vaildate(object t)
        {
            return t != null && int.Parse(t.ToString()) < _Max;
        }
    }
}
