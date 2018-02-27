﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Apache.NMS;
//using Apache.NMS.ActiveMQ;

//namespace KilowaySDK.ActiveMQ
//{
//    public class KActiveMQ
//    {
//        private IConnectionFactory factory;
//        private IConnection connection;
//        private ISession session;
//        /// <summary>
//        /// 生产者
//        /// </summary>
//        private IMessageProducer producer;
//        /// <summary>
//        /// 消费者
//        /// </summary>
//        private IMessageConsumer consumer;
//        /// <summary>
//        /// 消息
//        /// </summary>
//        private ITextMessage _message;
//        private bool isTopic = false;
//        private bool hasSelector = false;
//        private const string ClientID = "clientid";
//        private const string Selector = "filter='demo'";
//        private bool sendSuccess = false;
//        private bool receiveSuccess = false;

//        /// <summary>
//        /// ActiveMQ构造函数 初始化网络参数
//        /// </summary>
//        /// <param name="remoteAddress"> 远程登陆地址</param>
//        public KActiveMQ(string remoteAddress = null)
//        {
//            try
//            {
//                if (remoteAddress != null)
//                {
//                    factory = new ConnectionFactory("tcp://" + remoteAddress + ":61616/");
//                }
//                else
//                {
//                    factory = new ConnectionFactory("tcp://localhost:61616/");
//                }
//                //通过工厂建立连接  
//                connection = factory.CreateConnection();
//                connection.ClientId = ClientID;
//                connection.Start();
//                //通过连接创建Session会话  
//                session = connection.CreateSession();
//            }
//            catch (Exception ex)
//            {
//                sendSuccess = false;
//                receiveSuccess = false;
//                Console.WriteLine("Exception:{0}", ex.Message);
//                Console.ReadLine();
//                throw ex;
//            }
            
//        }
//        ~KActiveMQ()
//        {
//            //this.ShutDown();  
//        }

//        /// <summary>  
//        /// 初始化  
//        /// </summary>  
//        /// <param name="topic">选择是否是Topic</param>  
//        /// <param name="name">队列名</param>  
//        /// <param name="selector">是否设置过滤</param>  
//        public bool InitQueueOrTopic(bool topic, string name, bool selector = false)
//        {
//            try
//            {
//                //通过会话创建生产者、消费者  
//                if (topic)
//                {
//                    producer = session.CreateProducer(new Apache.NMS.ActiveMQ.Commands.ActiveMQTopic(name));
//                    if (selector)
//                    {
//                        consumer = session.CreateDurableConsumer(new Apache.NMS.ActiveMQ.Commands.ActiveMQTopic(name), ClientID, Selector, false);
//                        hasSelector = true;
//                    }
//                    else
//                    {
//                        consumer = session.CreateDurableConsumer(new Apache.NMS.ActiveMQ.Commands.ActiveMQTopic(name), ClientID, null, false);
//                        hasSelector = false;
//                    }
//                    isTopic = true;
//                }
//                else
//                {
//                    producer = session.CreateProducer(new Apache.NMS.ActiveMQ.Commands.ActiveMQQueue(name));
//                    if (selector)
//                    {
//                        consumer = session.CreateConsumer(new Apache.NMS.ActiveMQ.Commands.ActiveMQQueue(name), Selector);
//                        hasSelector = true;
//                    }
//                    else
//                    {
//                        consumer = session.CreateConsumer(new Apache.NMS.ActiveMQ.Commands.ActiveMQQueue(name));
//                        hasSelector = false;
//                    }
//                    isTopic = false;
//                }
//                //创建一个发送的消息对象  
//                _message = producer.CreateTextMessage();
//            }
//            catch (System.Exception e)
//            {
//                sendSuccess = false;
//                receiveSuccess = false;
//                Console.WriteLine("Exception:{0}", e.Message);
//                Console.ReadLine();
//                throw e;
//            }

//            return sendSuccess;
//        }


//        public bool SendMessage(string message, string msgId = "defult", MsgPriority priority = MsgPriority.Normal)
//        {
//            if (producer == null)
//            {
//                sendSuccess = false;
//                Console.WriteLine("call InitQueueOrTopic() first!!");
//                return false;
//            }

//            Console.WriteLine("Begin send messages...");

//            //给这个对象赋实际的消息  
//            _message.NMSCorrelationID = msgId;
//            _message.Properties["MyID"] = msgId;
//            _message.NMSMessageId = msgId;
//            _message.Text = message;
//            Console.WriteLine(message);

//            if (isTopic)
//            {
//                sendSuccess = ProducerSubcriber(message, priority);
//            }
//            else
//            {
//                sendSuccess = P2P(message, priority);
//            }

//            return sendSuccess;
//        }


//        public string GetMessage()
//        {
//            if (producer == null)
//            {
//                Console.WriteLine("call InitQueueOrTopic() first!!");
//                return null;
//            }

//            Console.WriteLine("Begin receive messages...");
//            ITextMessage revMessage = null;
//            try
//            {
//                //同步阻塞10ms,没消息就直接返回null,注意此处时间不能设太短，否则还没取到消息就直接返回null了！！！  
//                revMessage = consumer.Receive(new TimeSpan(TimeSpan.TicksPerMillisecond * 10)) as ITextMessage;
//            }
//            catch (System.Exception e)
//            {
//                receiveSuccess = false;
//                Console.WriteLine("Exception:{0}", e.Message);
//                Console.ReadLine();
//                throw e;
//            }

//            if (revMessage == null)
//            {
//                Console.WriteLine("No message received!");
//                return null;
//            }
//            else
//            {
//                Console.WriteLine("Received message with Correlation ID: " + revMessage.NMSCorrelationID);
//                //Console.WriteLine("Received message with Properties'ID: " + revMessage.Properties["MyID"]);  
//                Console.WriteLine("Received message with text: " + revMessage.Text);
//            }

//            return revMessage.Text;
//        }

//        //P2P模式，一个生产者对应一个消费者  
//        private bool P2P(string message, MsgPriority priority)
//        {
//            try
//            {
//                if (hasSelector)
//                {
//                    //设置消息对象的属性，这个很重要，是Queue的过滤条件，也是P2P消息的唯一指定属性  
//                    _message.Properties.SetString("filter", "demo");  //P2P模式  
//                }
//                producer.Priority = priority;
//                //设置持久化  
//                producer.DeliveryMode = MsgDeliveryMode.Persistent;
//                //生产者把消息发送出去，几个枚举参数MsgDeliveryMode是否持久化，MsgPriority消息优先级别，存活时间，当然还有其他重载  
//                producer.Send(_message, MsgDeliveryMode.Persistent, priority, TimeSpan.MinValue);
//            }
//            catch (System.Exception e)
//            {
//                sendSuccess = false;
//                Console.WriteLine("Exception:{0}", e.Message);
//                Console.ReadLine();
//                throw e;
//            }

//            return sendSuccess;
//        }


//        //发布订阅模式，一个生产者多个消费者   
//        private bool ProducerSubcriber(string message, MsgPriority priority)
//        {
//            try
//            {
//                producer.Priority = priority;
//                //设置持久化,如果DeliveryMode没有设置或者设置为NON_PERSISTENT，那么重启MQ之后消息就会丢失  
//                producer.DeliveryMode = MsgDeliveryMode.Persistent;
//                producer.Send(_message, Apache.NMS.MsgDeliveryMode.Persistent, priority, TimeSpan.MinValue);
//                //System.Threading.Thread.Sleep(1000);    
//            }
//            catch (System.Exception e)
//            {
//                sendSuccess = false;
//                Console.WriteLine("Exception:{0}", e.Message);
//                Console.ReadLine();
//                throw e;
//            }

//            return sendSuccess;
//        }


//        public void ShutDown()
//        {
//            Console.WriteLine("Close connection and session...");
//            session.Close();
//            connection.Close();
//        }


//    }
//}
