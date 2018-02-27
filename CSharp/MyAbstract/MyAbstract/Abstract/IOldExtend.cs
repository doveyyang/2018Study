using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbstract.Abstract
{
    public interface IOldExtend
    {
        void photo();

        /// <summary>
        /// 索引1器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        int this[int index] { get;set; }

        int Id { get; set; }
        event Action DoEvent;
    }
}
