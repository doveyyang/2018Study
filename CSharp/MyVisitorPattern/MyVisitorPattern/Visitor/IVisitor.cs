using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisitorPattern.Visitor
{
    public interface IVisitor
    {
        void VideoFree();
        void VideoVIP();
    }
}
