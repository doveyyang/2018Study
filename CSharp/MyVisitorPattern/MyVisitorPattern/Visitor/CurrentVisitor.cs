using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisitorPattern.Visitor
{
    public class CurrentVisitor: IVisitor
    {
        public void VideoFree()
        {
            Console.WriteLine($"no Video,only code");
        }

        public void VideoVIP()
        {
            Console.WriteLine($"all Video all code");
        }
    }
}
