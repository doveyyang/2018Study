using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProxyPattern
{
    public class ProxySubject : ISubject
    {
        private static ISubject _subject = new RailwaySubject();

        public void DoSomeThing()
        {
            if (Session.IsLogin)
            {
                _subject.DoSomeThing();
            }
            else
            {
                throw new Exception();
            }
            
        }

        public void GetSomeThing()
        {
            _subject.GetSomeThing();
        }
    }
}
