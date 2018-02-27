using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 数据访问抽象层 
/// </summary>
namespace Kiloway.IDAL
{
    /// <summary>
    ///    /// 
    /// </summary>
    public abstract class AbstractPhone
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void System();
        public void  Call()
        {
            Console.WriteLine("Call - {0}",this.GetType().Name);
        }
    }
}
