
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SampleThread
{
    internal class Program
    {
        static int counter = 0;
        static readonly object lockObject = new object();
        static void Main()
        {
           
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine($"Final Counter:{counter}");
        }
        static void Increment()
        {
           
            for (int i = 0; i < 100000; i++)
                // this stops from multi threading.If the lock is commented we get diff value.
                lock (lockObject)
                {

                    counter++;

                }
        }
        //static void Main()
        //{
        //    Thread thread = new Thread(new ThreadStart(Worker));
        //    thread.Start();
        //    // OS scheduler decides which to go 
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine($"Main: {i}");
        //        Thread.Sleep(100);

        //    }

            
        //    Console.WriteLine($"Main Thread: {Thread.CurrentThread.ManagedThreadId}");
        //    thread.Join();
        //}
        //static void Worker()
        //{
        //    Console.WriteLine($"Worker Thread{Thread.CurrentThread.ManagedThreadId}");
        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.WriteLine($"Worker thread: {i}");
        //        Thread.Sleep(1000);

        //    }
           
        }
    }

