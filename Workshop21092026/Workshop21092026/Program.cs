using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Metrics;
using System.Reflection;


namespace Workshop21092026
{
    //    internal class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Thread thread = new Thread(new ThreadStart(DoWork));
    //            thread.Start();
    //            Console.WriteLine($"Main Thread: {Thread.CurrentThread.ManagedThreadId}");
    //            thread.Join();
    //            Console.WriteLine($"Worker thread Completed");
    //        }

    //        static void DoWork()
    //        {
    //            Console.WriteLine($"Worker Thread: {Thread.CurrentThread.ManagedThreadId}");
    //            Console.WriteLine("Downloading");
    //            for (int i = 0; i <= 5; i++)
    //            {
    //                Console.WriteLine($"Main Thread{i}");
    //                Thread.Sleep(100);
    //            }
    //        }

    //    }


   

    internal class Program
    {
        static int counter = 0;
        private static readonly object lockObject = new object();
        static void Main()
        {
            Thread thread1 = new Thread(Increament);
            Thread thread2 = new Thread(Increament);

            thread1.Start();
            thread2.Start();

            thread1.Join(); //Main thread is waiting and runs only after workerthreads
            thread2.Join();

            Console.WriteLine($"Final Counter: {counter}");
        }

        static void Increament()
        {
            lock (lockObject) //to avoid multithreading
            {
                for (int i = 0; i < 10000000; i++)
                {
                    counter++;
                }
            }
        }


    }

}
