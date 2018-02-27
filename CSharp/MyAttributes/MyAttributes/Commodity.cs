using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAttributes.AOP;

namespace MyAttributes
{
    public class Commodity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [LengthAttribute(999999999)]
        public int Price { get; set; }
        public string Url { get; set; }
        public long Number { get; set; }
    }
}
