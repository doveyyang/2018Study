using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {
                    ISubject subject = new RailwaySubject();
                    subject.DoSomeThing();
                    subject.GetSomeThing();
                }
                {
                    Console.Write("Name:");
                    string account = Console.ReadLine();
                    Console.Write("Password:");
                    string pwd = Console.ReadLine();

                    if (account.Equals("admin") && pwd.Equals("123456"))
                    {
                        Session.IsLogin = true;
                    }
                    ISubject subject = new ProxySubject();
                    subject.DoSomeThing();
                    subject.GetSomeThing();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
    public class Session
    {
        public static bool IsLogin = false;
    }
}

