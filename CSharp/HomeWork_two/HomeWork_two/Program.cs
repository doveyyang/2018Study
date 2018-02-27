using Common;
using Interface;
using System;
using System.Threading;
using VocalImitation;

namespace HomeWork_two
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                #region //1.实例化口技表演者
                EastVocalImitation east = new EastVocalImitation()
                {
                    Chair = "East Chair",
                    Fan = "East Fan",
                    Person = "Eastern People",
                    Ruler = "East Ruler",
                    Table = "East Table"
                };
                east.FireEvents += () =>
                {
                    Helper.Out2ConsoleAndFile("East Fire Event");
                };

                WestVocalImitation west = new WestVocalImitation()
                {
                    Chair = "West Chair",
                    Fan = "West Fan",
                    Person = "Western People",
                    Ruler = "West Ruler",
                    Table = "West Table"
                };
                west.FireEvents += () =>
                {
                    Helper.Out2ConsoleAndFile("West Fire Event");
                };
                NorthVocalImitation north = new NorthVocalImitation()
                {
                    Chair = "North Chair",
                    Fan = "North Fan",
                    Person = "North People",
                    Ruler = "North Ruler",
                    Table = "North Table"
                };
                north.FireEvents += () =>
                {
                    Helper.Out2ConsoleAndFile("North Fire Event");
                };
                SouthVocalImitation south = new SouthVocalImitation()
                {
                    Chair = "South Chair",
                    Fan = "South Fan",
                    Person = "South People",
                    Ruler = "South Ruler",
                    Table = "South Table"
                };
                south.FireEvents += () => Console.WriteLine("夫起大呼，");
                south.FireEvents += () => Console.WriteLine("妇亦起大呼,");
                south.FireEvents += () => Console.WriteLine("两儿齐哭,");
                south.FireEvents += () => Console.WriteLine("俄而百千人,");
                south.FireEvents += () => Console.WriteLine("百千儿哭,");
                south.FireEvents += () => Console.WriteLine("百千犬吠。");

                #endregion

                //ActionAll(east);

                //ActionAll(west);
                //ActionAll(north);
                //ActionAll(south);



                for (int temperature = 100; temperature < 1200; temperature += 100)
                {
                    Helper.Out2ConsoleAndFile($"Temperature is {temperature}");
                    FireAll(east, temperature);
                    FireAll(west, temperature);
                    FireAll(north, temperature);
                    FireAll(south, temperature);
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }

        public static void ActionAll<T>(T t) where T : BaseVocalImitation, ICharge
        {
            Helper.Out2ConsoleAndFile("Name :" + t.GetType().Name);
            Type type = typeof(T);

            foreach (var perperty in type.GetProperties())
            {
                Helper.Out2ConsoleAndFile("Name:" + perperty.Name + "   Value:" + perperty.GetValue(t));
            }

            t.StartAction();
            t.BeginAction();
            t.DogBark();
            t.Say();
            t.Wind();
            t.EndAction();
            t.Charge();

            Helper.Out2ConsoleAndFile("----------------------------");
        }

        public static void FireAll<T>(T t, int temperature) where T : BaseVocalImitation, ICharge
        {
            t.OnFireStart(temperature);
        }
    }
}
