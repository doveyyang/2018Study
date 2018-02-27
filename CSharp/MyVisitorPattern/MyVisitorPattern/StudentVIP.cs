using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyVisitorPattern.Visitor;

namespace MyVisitorPattern
{
    public class StudentVIP : Student
    {
        public override void Video()
        {
            Console.WriteLine($"{this.Name} get all video.");
        }
        public override void VideoVisitor(IVisitor visitor)
        {
            Console.Write($"{this.Name}: ");
            visitor.VideoVIP();
        }
    }
}
