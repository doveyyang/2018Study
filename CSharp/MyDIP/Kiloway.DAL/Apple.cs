using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiloway.IDAL;

/// <summary>
/// 数据访问层
/// </summary>
namespace Kiloway.DAL
{
    public class Apple : AbstractPhone
    {
        public override void System()
        {
            Console.WriteLine("IOS System - {0}",this.GetType().Name);
        }
    }
}
