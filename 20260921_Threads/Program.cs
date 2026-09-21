using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SampleThread
{
    internal class Program
    {
        static int num = 0;
        static readonly object lockObject = new object();
        static void Main()
        {
            Console.WriteLine($"MainThread:{Thread.CurrentThread.ManagedThreadId}");
            Thread odd = new Thread(DisplayOdd);
            Thread even = new Thread(DisplayEven);

            odd.Start();
            even.Start();

            odd.Join();
            even.Join();
            Console.WriteLine($"Program ended");
        }
        static void DisplayOdd()
        {
            #region OtherWayToDoInOdd
            //while (num < 10)
            //{
            //    // this stops from multi threading.If the lock is commented we get diff value.
            //    lock (lockObject)
            //    {
            //        if (num % 2 != 0)
            //        {
            //            Console.WriteLine($"the odd number is:{num}");
            //            Thread.Sleep(1000);
            //            num++;
            //        }

            //    }
            //}
            #endregion
            Console.WriteLine($"WorkerThread1:{Thread.CurrentThread.ManagedThreadId}");
            lock (lockObject)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine($"the odd number is{i}");
                        Thread.Sleep(1000);
                    }
                }
            }
        }
        static void DisplayEven()
        {
            Console.WriteLine($"WorkerThread2:{Thread.CurrentThread.ManagedThreadId}");
            #region OtherWayToDoInEven
            //while (num < 10)
            //{
            //    // this stops from multi threading.If the lock is commented we get diff value.
            //    lock (lockObject)
            //    {
            //        if (num % 2 == 0)
            //        {
            //            Console.WriteLine($"the even number is:{num}");
            //            Thread.Sleep(1000);

            //            num++;
            //        }

            //    }
            //}
            #endregion
            lock (lockObject)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine($"the even number is{i}");
                        Thread.Sleep(1000);
                        }
                    }
                }

            }
    }
}
    