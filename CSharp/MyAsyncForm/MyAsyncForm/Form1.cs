using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAsyncForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private delegate void DoSomethingDelegate(string name);

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button1 Start {0}", Thread.CurrentThread.ManagedThreadId);

            DoSomethingDelegate method = new DoSomethingDelegate(this.DoSomeThingLong);
            //method.Invoke("123");
            //method.Invoke("456");

            //method.BeginInvoke("123",null,null);
            //method.BeginInvoke("456",null,null);
            IAsyncResult asyncResult = null;
            //AsyncCallback callback = t =>
            //{
            //    Console.WriteLine(t.Equals(asyncResult));
            //    Console.WriteLine(t.AsyncState); //状态参数
            //    Console.WriteLine("这里是回调函数 {0}", Thread.CurrentThread.ManagedThreadId);
            //};

            ////第一个参数：委托的参数
            ////第二个参数：回调
            ////第三个参数：回调的参数
            //asyncResult = method.BeginInvoke("123", callback, "ABCDEF");


            //asyncResult = method.BeginInvoke("456", t =>
            //   {
            //       Console.WriteLine(t.Equals(asyncResult));
            //       Console.WriteLine(t.AsyncState); //状态参数
            //        Console.WriteLine("这里是回调函数 {0}", Thread.CurrentThread.ManagedThreadId);
            //   }, "Test");

            //等待异步执行结束之后，主线程还要做事
            //int i = 1;
            //while (!asyncResult.IsCompleted)//检测委托的异步调用是否结束
            //{
            //    Console.WriteLine(".....compute...{0}%", 10 * i++);
            //    Thread.Sleep(100);//存在性能损耗
            //}

            //asyncResult.AsyncWaitHandle.WaitOne(); // 一直等待
            //asyncResult.AsyncWaitHandle.WaitOne(-1); // 一直等待
            //asyncResult.AsyncWaitHandle.WaitOne(1000); // 等待1000ms，超时就不等了

            //method.EndInvoke(asyncResult);

            Func<int, string> func = t =>
                {
                    DoSomeThingLong("T");
                    return "2018给力";
                };
            asyncResult = func.BeginInvoke(DateTime.Now.Millisecond, t =>
            {
                string str2 = func.EndInvoke(t);
                Console.WriteLine(t.AsyncState); //状态参数
                Console.WriteLine("这里是回调函数 {0}", Thread.CurrentThread.ManagedThreadId);
            }, "AlwayOnLine");

            //string str = func.EndInvoke(asyncResult);

            Console.WriteLine("Button1 End {0}", Thread.CurrentThread.ManagedThreadId);
        }

        private void DoSomeThingLong(string name)
        {
            Console.WriteLine(" DoSomeThingLong Start {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine(" DoSomeThingLong End{0}", Thread.CurrentThread.ManagedThreadId);
        }

        private delegate void DoThing(string text);
        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click Start...");

            DoThing method = new DoThing(DoThingLong);

            //同步执行委托
            //method.Invoke("test");

            //异步执行
            //method.BeginInvoke("Test BeginInvoke",null,null);

            //异步执行之后执行回调
            //AsyncCallback callback = t => {
            //    Console.WriteLine("执行了回调函数");
            //    Console.WriteLine($"AsyncState {t.AsyncState}");
            //};
            //method.BeginInvoke("BeginInvoke", callback, null);
            //method.BeginInvoke("BeginInvoke", callback, "参数3");

            Func<int, string> func = t1 =>
            {
                DoThingLong("Func<int,string>");
                return t1.ToString();
            };
            IAsyncResult asyncResult = func.BeginInvoke(123456,t2=> {

               

                Console.Write("回调函数 {0}",Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine($"AsyncState {t2.AsyncState}");
            }, "Func<int, string>");

            //等待异步执行结束
            //asyncResult.AsyncWaitHandle.WaitOne();
            //asyncResult.AsyncWaitHandle.WaitOne(-1);
            //asyncResult.AsyncWaitHandle.WaitOne(1000);
            //func.EndInvoke(asyncResult);

            string str = func.EndInvoke(asyncResult);
            Console.WriteLine("委托的执行结果：{0}", str);
            var t = Convert.ChangeType("5",typeof(int));
            Console.WriteLine("Click End...");
        }
        private void DoThingLong(string text)
        {
            Console.WriteLine("DoThingLong {1} Start {0}",Thread.CurrentThread.ManagedThreadId,text);
            Thread.Sleep(2000);
            Console.WriteLine("DoThingLong {1} End{0}", Thread.CurrentThread.ManagedThreadId,text);
        }
    }
}
