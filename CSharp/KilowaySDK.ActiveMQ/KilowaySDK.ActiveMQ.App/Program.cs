using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KilowaySDK.ActiveMQ.Interface;

namespace KilowaySDK.ActiveMQ.App.Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region
                //{
                //    AdvisoryExample ex = new AdvisoryExample();

                //    // ex.EnumerateQueues();
                //    //ex.EnumerateTopics();
                //    ex.EnumerateDestinations();

                //    ex.ShutDown();
                //}
                //{
                //    ActiveMQTest test = new ActiveMQTest();
                //    test.Show();

                //}

                //http://blog.csdn.net/peterpan_hai/article/details/52354913

                #endregion

                var producer = new ActiveMQProducer();
                producer.BrokerUri = @"tcp://127.0.0.1:61616/";
                producer.UserName = "admin";
                producer.Password = "admin";
                //consumer.QueueName = "Queue_1";
                //consumer.MQMode = MQMode.Queue;
                producer.QueueName = "Topic_1";
                producer.MQMode = MQMode.Topic;

                Console.WriteLine("打开ActiveMQ中...");
                producer.Open();
                Console.WriteLine("打开ActiveMQ完成.");
                var message = new BaseMessage()
                {
                    //初始化业务数据对象...
                    Opeation = "IN",
                    Result = "Success"
                };                
                //发送到队列, Put对象类必须使用[Serializable]注解属性
                producer.Put(message);
                Console.WriteLine("Send: "+message);

            }
            catch (Exception  ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            Console.ReadKey();

        }
    }
}
