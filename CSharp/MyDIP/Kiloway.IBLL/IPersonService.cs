using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiloway.DAL;
using Kiloway.IDAL;

/// <summary>
/// 业务逻辑抽象层
/// </summary>
namespace Kiloway.IBLL
{
    public interface IPersonService
    {
        void Study();
        void Play(AbstractPhone phone);
        //void PlayApple(Apple phone);
    }
}
