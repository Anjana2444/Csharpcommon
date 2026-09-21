using System;
using System.Collections.Generic;
using System.Text;

namespace Threading
{
    internal class WorkerThread
    {
        static void Main(String[] args)
        {
            //Thread workerThread = new Thread(new ThreadStart(Worker));
            //workerThread.Start();
            for (int i = 0; i < 3; i++)
            {
                Thread workerThread = new Thread(new ThreadStart(DoWork));
                workerThread.Start();
                Console.WriteLine($"Main Thread: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
            //workerThread.Join();
            //Console.WriteLine("Main Thread Finished");
            Console.ReadLine();
        }
        //static void Worker()
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.WriteLine($"Worker Thread: {Thread.CurrentThread.ManagedThreadId}");
        //        Thread.Sleep(1000);
        //    }
        //}
        static void DoWork()
        {
            Console.WriteLine($"Worker Thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
        }
    }
}
