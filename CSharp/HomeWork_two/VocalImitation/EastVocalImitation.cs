using Common;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocalImitation
{
    public class EastVocalImitation : BaseVocalImitation, ICharge
    {
        public EastVocalImitation()
        {
            
        }

        public void Charge()
        {
            Helper.Out2ConsoleAndFile("East Charge $200");
        }

        public override void DogBark()
        {
            Helper.Out2ConsoleAndFile("East Dog Bark.");
        }

        public override void Say()
        {
            Helper.Out2ConsoleAndFile("East Say.");
        }

        public override void Wind()
        {
            Helper.Out2ConsoleAndFile("East Wind.");
        }
    }
}
