
using System;
using System.IO;

namespace Common
{
    public class Helper
    {
        public static void Out2ConsoleAndFile(string msg)
        {
            try
            {
                Console.WriteLine(msg);
                using (var fstream = File.AppendText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt")))
                {
                    fstream.WriteLine(msg);
                    fstream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

        }
    }
}
