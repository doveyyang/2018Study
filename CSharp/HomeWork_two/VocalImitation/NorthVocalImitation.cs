using Common;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocalImitation
{
    public class NorthVocalImitation : BaseVocalImitation, ICharge
    {
        public NorthVocalImitation()
        {
            this.Temperature = 1000;
        }
        public void Charge()
        {
            Helper.Out2ConsoleAndFile("North Charge $100");
        }

        public override void DogBark()
        {
            Helper.Out2ConsoleAndFile("North Dog Bark.");
        }

        public override void Say()
        {
            Helper.Out2ConsoleAndFile("North Say.");
        }

        public override void Wind()
        {
            Helper.Out2ConsoleAndFile("North Wind.");
        }
        public override void EndAction()
        {
            Helper.Out2ConsoleAndFile(" North - End Action...");
        }
    }
}
