using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisitorPattern.Visitor
{
    public class PastVisitor: IVisitor
    {
        public void VideoFree()
        {
            Console.WriteLine($"no video,only code");
        }

        public void VideoVIP()
        {
            Console.WriteLine($"some video,only code");
        }
    }
}
