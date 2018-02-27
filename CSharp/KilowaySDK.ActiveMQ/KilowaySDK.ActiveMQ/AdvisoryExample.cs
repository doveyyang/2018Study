
///*
// * Licensed to the Apache Software Foundation (ASF) under one or more
// * contributor license agreements.  See the NOTICE file distributed with
// * this work for additional information regarding copyright ownership.
// * The ASF licenses this file to You under the Apache License, Version 2.0
// * (the "License"); you may not use this file except in compliance with
// * the License.  You may obtain a copy of the License at
// *
// *     http://www.apache.org/licenses/LICENSE-2.0
// *
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// */

//using System;
//using Apache.NMS;
//using Apache.NMS.Util;
//using Apache.NMS.ActiveMQ;
//using Apache.NMS.ActiveMQ.Commands;

//namespace KilowaySDK.ActiveMQ
//{
//    public class AdvisoryExample
//    {
//        private IConnection connection;
//        private ISession session;

//        public const String QUEUE_ADVISORY_DESTINATION = "ActiveMQ.Advisory.Queue";
//        public const String TOPIC_ADVISORY_DESTINATION = "ActiveMQ.Advisory.Topic";
//        public const String TEMPQUEUE_ADVISORY_DESTINATION = "ActiveMQ.Advisory.TempQueue";
//        public const String TEMPTOPIC_ADVISORY_DESTINATION = "ActiveMQ.Advisory.TempTopic";

//        public const String ALLDEST_ADVISORY_DESTINATION = QUEUE_ADVISORY_DESTINATION + "," +
//        TOPIC_ADVISORY_DESTINATION + "," +
//        TEMPQUEUE_ADVISORY_DESTINATION + "," +
//        TEMPTOPIC_ADVISORY_DESTINATION;

//        public AdvisoryExample()
//        {
//            IConnectionFactory factory = new ConnectionFactory();

//            connection = factory.CreateConnection();
//            connection.Start();
//            session = connection.CreateSession();
//        }

//        public void EnumerateQueues()
//        {
//            Console.WriteLine("Listing all Queues on Broker:");

//            IDestination dest = session.GetTopic(QUEUE_ADVISORY_DESTINATION);

//            using (IMessageConsumer consumer = session.CreateConsumer(dest))
//            {
//                IMessage advisory;

//                while ((advisory = consumer.Receive(TimeSpan.FromMilliseconds(2000))) != null)
//                {
//                    ActiveMQMessage amqMsg = advisory as ActiveMQMessage;

//                    if (amqMsg.DataStructure != null)
//                    {
//                        DestinationInfo info = amqMsg.DataStructure as DestinationInfo;
//                        if (info != null)
//                        {
//                            Console.WriteLine("   Queue: " + info.Destination.ToString());
//                        }
//                    }
//                }
//            }
//            Console.WriteLine("Listing Complete.");
//        }

//        public void EnumerateTopics()
//        {
//            Console.WriteLine("Listing all Topics on Broker:");

//            IDestination dest = session.GetTopic(TOPIC_ADVISORY_DESTINATION);

//            using (IMessageConsumer consumer = session.CreateConsumer(dest))
//            {
//                IMessage advisory;

//                while ((advisory = consumer.Receive(TimeSpan.FromMilliseconds(2000))) != null)
//                {
//                    ActiveMQMessage amqMsg = advisory as ActiveMQMessage;

//                    if (amqMsg.DataStructure != null)
//                    {
//                        DestinationInfo info = amqMsg.DataStructure as DestinationInfo;
//                        if (info != null)
//                        {
//                            Console.WriteLine("   Topic: " + info.Destination.ToString());
//                        }
//                    }
//                }
//            }
//            Console.WriteLine("Listing Complete.");
//        }

//        public void EnumerateDestinations()
//        {
//            Console.WriteLine("Listing all Destinations on Broker:");

//            IDestination dest = session.GetTopic(ALLDEST_ADVISORY_DESTINATION);

//            using (IMessageConsumer consumer = session.CreateConsumer(dest))
//            {
//                IMessage advisory;

//                while ((advisory = consumer.Receive(TimeSpan.FromMilliseconds(2000))) != null)
//                {
//                    ActiveMQMessage amqMsg = advisory as ActiveMQMessage;

//                    if (amqMsg.DataStructure != null)
//                    {
//                        DestinationInfo info = amqMsg.DataStructure as DestinationInfo;
//                        if (info != null)
//                        {
//                            string destType = info.Destination.IsTopic ? "Topic" : "Qeue";
//                            destType = info.Destination.IsTemporary ? "Temporary" + destType : destType;
//                            Console.WriteLine("   " + destType + ": " + info.Destination.ToString());
//                        }
//                    }
//                }
//            }
//            Console.WriteLine("Listing Complete.");
//        }

//        public void ShutDown()
//        {
//            session.Close();
//            connection.Close();
//        }

//    }
//}