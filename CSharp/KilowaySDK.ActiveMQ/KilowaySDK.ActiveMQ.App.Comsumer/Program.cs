using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS.ActiveMQ.Commands;
using KilowaySDK.ActiveMQ.Interface;
using Newtonsoft.Json;

namespace KilowaySDK.ActiveMQ.App.Comsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //http://blog.csdn.net/peterpan_hai/article/details/52354913


                var consumer = new ActiveMQConsumer();
                consumer.BrokerUri = @"tcp://127.0.0.1:61616/";
                consumer.UserName = "admin";
                consumer.Password = "admin";
                //consumer.QueueName = "Queue_1";
                //consumer.MQMode = MQMode.Queue;
                consumer.QueueName = "Topic_1";
                consumer.MQMode = MQMode.Topic;
                Console.WriteLine($"consumer Start Listen {Enum.GetName(typeof(MQMode),consumer.MQMode)} : {consumer.QueueName}");
                //获取到原生消息类型
                consumer.OnMessageReceived = (msg) =>
                {
                    Console.WriteLine("-----------Received Message-------------");

                    if (msg is ActiveMQTextMessage)
                    {
                        var message = msg as ActiveMQTextMessage;
                        Console.WriteLine($"Text:{message.Text}");
                    }
                    else if (msg is ActiveMQBytesMessage)
                    {
                        var message = msg as ActiveMQBytesMessage;
                        Console.WriteLine(message.ReadString());
                    }
                    else
                    {
                        var bytesMessage = msg as ActiveMQObjectMessage;
                        if (bytesMessage != null)
                        {
                            Console.WriteLine($"Body:{Newtonsoft.Json.JsonConvert.SerializeObject(bytesMessage.Body)}");
                            //var buffer = new byte[bytesMessage.Size()];
                            ////bytesMessage.WriteBytes(buffer);
                            //bytesMessage.ReadBytes(buffer);
                            //var result = buffer.ToObject<BaseMessage>();
                            //Console.WriteLine(JsonConvert.SerializeObject(result));
                        }
                    }
                };

                //获取自定义的数据类型
                consumer.OnBaseMessageReceived = (msg) =>
                {
                    Console.WriteLine("-----------Received BaseMessage-------------");
                    Console.Write($"Opeation:{msg.Opeation} Result:{msg.Result}");
                };
                consumer.Open();
                consumer.StartListen();
            }
            catch (Exception  ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            Console.ReadKey();

        }
    }
}
