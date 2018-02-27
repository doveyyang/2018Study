using Common;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocalImitation
{
    public class SouthVocalImitation : BaseVocalImitation, ICharge
    {
        public SouthVocalImitation()
        {
            this.Temperature = 800;
        }
        public void Charge()
        {
            Helper.Out2ConsoleAndFile("South Charge $300");
        }

        public override void DogBark()
        {
            Helper.Out2ConsoleAndFile("South Dog Bark.");
        }

        public override void Say()
        {
            Helper.Out2ConsoleAndFile("South Say.");
        }

        public override void Wind()
        {
            Helper.Out2ConsoleAndFile("South Wind.");
        }
        public override void BeginAction()
        {
            Helper.Out2ConsoleAndFile(" South - Begin Action...");
        }
    }
}
