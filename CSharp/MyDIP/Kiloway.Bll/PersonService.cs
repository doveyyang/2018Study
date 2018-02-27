using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiloway.IBLL;
using Kiloway.IDAL;

/// <summary>
/// 业务逻辑层
/// </summary>
namespace Kiloway.BLL
{
    public class PersonService : IPersonService
    {       

        public void Play(AbstractPhone phone)
        {
            Console.WriteLine("AbstractPhone Play - {0}",phone);
            phone.System();
            phone.Call();
        }
        
        public void Study()
        {
            Console.WriteLine(" Study {0}",this.GetType().Name);
        }
    }
}
