using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyVisitorPattern.Visitor;

namespace MyVisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var sList = new List<Student>()
                {
                    new StudentFree(){
                        Id =1,
                        Name = "HeXin"
                    },
                     new StudentFree(){
                        Id =2,
                        Name = "ZhangSan"
                    },
                     new StudentVIP(){
                         Id = 3,
                         Name="GuoLi"
                     },
                     new StudentVIP(){
                         Id = 4,
                         Name="JiHai"
                     }
                };

                {
                    foreach (var student in sList)
                    {
                        Console.WriteLine("--");
                        student.Study();

                    }
                }

                Console.WriteLine("*******************************");

                {
                    foreach (var student in sList)
                    {
                        Console.WriteLine("--");
                        student.Study();

                        //For Video
                        //if (student is StudentFree)
                        //{
                        //    Console.WriteLine($"{student.Name} get free video.");
                        //}
                        //else if (student is StudentVIP)
                        //{
                        //    Console.WriteLine($"{student.Name} get all video.");
                        //}
                        //else
                        //{
                        //    Console.WriteLine($"{student.Name} can't get video.");
                        //}

                        student.Video();
                    }
                }

                Console.WriteLine("*******************************");

                {
                    IVisitor visitor = new CurrentVisitor();
                    foreach (var student in sList)
                    {
                        Console.WriteLine("--");
                        student.Study();

                        //For Video
                        //if (student is StudentFree)
                        //{
                        //    Console.WriteLine($"{student.Name} get free video.");
                        //}
                        //else if (student is StudentVIP)
                        //{
                        //    Console.WriteLine($"{student.Name} get all video.");
                        //}
                        //else
                        //{
                        //    Console.WriteLine($"{student.Name} can't get video.");
                        //}

                        student.VideoVisitor(visitor);
                    }
                }
                {
                    IVisitor visitor = new PastVisitor();
                    foreach (var student in sList)
                    {
                        Console.WriteLine("--");
                        student.Study();

                        //For Video
                        //if (student is StudentFree)
                        //{
                        //    Console.WriteLine($"{student.Name} get free video.");
                        //}
                        //else if (student is StudentVIP)
                        //{
                        //    Console.WriteLine($"{student.Name} get all video.");
                        //}
                        //else
                        //{
                        //    Console.WriteLine($"{student.Name} can't get video.");
                        //}

                        student.VideoVisitor(visitor);
                    }
                }

                {
                    IVisitor visitor = new FutureVisitor();
                    foreach (var student in sList)
                    {
                        Console.WriteLine("--");
                        student.Study();

                        //For Video
                        //if (student is StudentFree)
                        //{
                        //    Console.WriteLine($"{student.Name} get free video.");
                        //}
                        //else if (student is StudentVIP)
                        //{
                        //    Console.WriteLine($"{student.Name} get all video.");
                        //}
                        //else
                        //{
                        //    Console.WriteLine($"{student.Name} can't get video.");
                        //}

                        student.VideoVisitor(visitor);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            Console.ReadKey();
        }
    }
}
