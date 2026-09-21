//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SampleThread
//{
//    internal class Thread1
//    {
//        static void Main()
//        {
//            Thread thread = new Thread(new ThreadStart(Worker));
//            thread.Start();

//            //for (int i = 0; i < 3; i++)
//            //{
//            //    Console.WriteLine($"Worker thread: {i}");
//            //    Thread.Sleep(100);

//            //}

//           // thread.Join();
//           Console.WriteLine($"Main Thread: {Thread.CurrentThread.Name}");
//        }
//        static void Worker()
//        {
//            for (int i=0;i<3;i++)
//            {
//                Console.WriteLine($"Worker thread: {i}");
//                Thread.Sleep(100);

//            }
//        }
//    }
//}
