using Common;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocalImitation
{
    public class WestVocalImitation : BaseVocalImitation, ICharge
    {
        public void Charge()
        {
            Helper.Out2ConsoleAndFile("West Charge $400");
        }

        public override void DogBark()
        {
            Helper.Out2ConsoleAndFile("West Dog Bark.");
        }

        public override void Say()
        {
            Helper.Out2ConsoleAndFile("West Say.");
        }

        public override void Wind()
        {
            Helper.Out2ConsoleAndFile("West Wind.");
        }
        public override void EndAction()
        {
            Helper.Out2ConsoleAndFile(" West - End Action...");
        }
        public override void BeginAction()
        {
            Helper.Out2ConsoleAndFile(" West - Begin Action...");
        }
    }
}
