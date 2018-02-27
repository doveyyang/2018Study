using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProxyPattern
{
    public class RailwaySubject : ISubject
    {
        public void DoSomeThing()
        {
            Console.WriteLine(" DoSomeThing ");
        }

        public void GetSomeThing()
        {
            Console.WriteLine(" GetSomeThing ");
        }
    }
}
