using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyVisitorPattern.Visitor;

namespace MyVisitorPattern
{
    public abstract class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Study() {
            Console.WriteLine($"{this.Name} study .Net with Dovey.");
        }

        public abstract void Video();
        public abstract void VideoVisitor(IVisitor visitor);
    }
}
