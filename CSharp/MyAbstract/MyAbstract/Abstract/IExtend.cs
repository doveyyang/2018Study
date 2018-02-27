using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbstract.Abstract
{
    public interface IExtend
    {
        int Price { get; set; }

        int this[int index] { get;set; }

        event Action DoEvent;
        void Movie();
    }
}
