using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyThreadsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("--button1_Click End 主线程ID {0} --", Thread.CurrentThread.ManagedThreadId);

            ThreadStart threadStart = () =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Test Thread {0}", Thread.CurrentThread.ManagedThreadId);

            };
            List<Thread> threadList = new List<Thread>();

            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(threadStart);
                // thread.Start();
                //threadList.Add(thread);
                //ParameterizedThreadStart method = o => { Console.WriteLine("Test Thread {0}", Thread.CurrentThread.ManagedThreadId); };
                //Thread thread = new Thread(method);
                //thread.Start("test");
                this.ThreadCallback(threadStart, () => { Console.WriteLine("回调完成"); });
            }
            //foreach (Thread thread in threadList)
            //{
            //    thread.Join();
            //}
           

            watch.Stop();
            Console.WriteLine("--button1_Click End 主线程ID {0} {1}--", Thread.CurrentThread.ManagedThreadId, watch.ElapsedMilliseconds);
        }

        /// <summary>
        /// 使用了Thread完成多线程的回调
        /// </summary>
        /// <param name="method">多线程执行的任务</param>
        /// <param name="callback">执行完的回调函数</param>
        private void ThreadCallback(ThreadStart method, Action callback)
        {
            ThreadStart methodAll = new ThreadStart(() =>
            {
                method.Invoke();
                callback.Invoke();
            });
            Thread thread = new Thread(methodAll);
            thread.Start();
        }

    }
}
