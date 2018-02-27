using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisitorPattern.Visitor
{
    public class FutureVisitor : IVisitor
    {
        public void VideoFree()
        {
            Console.WriteLine("0.0");
        }

        public void VideoVIP()
        {
            Console.WriteLine("ALLLLLLL");
        }
    }
}
