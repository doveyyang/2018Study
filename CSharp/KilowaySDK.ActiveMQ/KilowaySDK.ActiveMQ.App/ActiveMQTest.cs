//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using Apache.NMS;

//namespace KilowaySDK.ActiveMQ.App
//{
//    public class ActiveMQTest
//    {
//        public void Show()
//        {
//            {
//                //KActiveMQ queue = new KActiveMQ();

//                //queue.InitQueueOrTopic(false, "Queue_1", false);

//                //for (int i = 0; i < 2; i++)
//                //{
//                //    queue.SendMessage($"Test {i + 1} Message_Queue_1", "Group_One", MsgPriority.Lowest);
//                //}


//                //Thread.Sleep(3000);
//                ////int num = 20;
//                ////while (num-- > 0)
//                ////{
//                ////    queue.GetMessage();
//                ////}
//                //queue.ShutDown();
//            }
//            {
//                //KActiveMQ queue2 = new KActiveMQ();

//                //queue2.InitQueueOrTopic(false, "Queue_2", false);
//                //for (int i = 0; i < 2; i++)
//                //{
//                //    queue2.SendMessage($"Test {i + 1} Message_Queue_2", "Group_One", MsgPriority.Lowest);

//                //}
//                //queue2.ShutDown();
//            }

//            {
//                KActiveMQ queue3 = new KActiveMQ();
//                queue3.InitQueueOrTopic(true,"Topic_2",false);
//                for (int i = 0; i < 2; i++)
//                {
//                    queue3.SendMessage($"Test {i + 1} Message_Topioc_2", "Group_One", MsgPriority.Lowest);

//                }

//                int num = 20;
//                while (num-- > 0)
//                {
//                    queue3.GetMessage();
//                }

//                queue3.ShutDown();

//            }
//        }
//    }
//}
