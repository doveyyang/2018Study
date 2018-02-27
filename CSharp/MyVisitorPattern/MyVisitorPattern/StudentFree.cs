using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyVisitorPattern.Visitor;

namespace MyVisitorPattern
{
    public class StudentFree : Student
    {
        /// <summary>
        /// Past
        /// Current
        /// Future
        /// </summary>
        public override void Video()
        {
            Console.WriteLine($"{this.Name} get free video.");
        }

        public override void VideoVisitor(IVisitor visitor)
        {
            Console.Write($"{this.Name}: ");
            visitor.VideoFree();
        }
    }
}
