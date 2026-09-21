using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace odd_even
{
    internal class Program
    {
        static int i = 1;
        //private static readonly object lockObject = new object();
        private static readonly object monitorObj = new object();
        static void Main()
        {
            Thread thread1 = new Thread(odd);

            Thread thread2 = new Thread(even);

            Console.WriteLine($"Main Thread: {Thread.CurrentThread.ManagedThreadId}");

            thread1.Start();
            thread2.Start();

            thread1.Join(); //Main thread is waiting and runs only after workerthreads
            thread2.Join();

            Console.WriteLine($"Worker threads Completed");

            static void even()
            {
                Monitor.Enter(monitorObj); 
                    Console.WriteLine($"Even Worker Thread: {Thread.CurrentThread.ManagedThreadId}");
                    while (i<=10)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine($"The even numbers are {i}");
                            Thread.Sleep(1000);
                        }
                    i++;
                    }
                Monitor.Exit(monitorObj);
            }
            static void odd()
            {
                Monitor.Enter(monitorObj);
                Console.WriteLine($"odd Worker Thread: {Thread.CurrentThread.ManagedThreadId}");
                    while(i <=10)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine($"The odd numbers are {i}");
                            Thread.Sleep(1000);
                        }
                    i++;
                    }
                Monitor.Exit(monitorObj);
            }

            Console.Read();

        }

    }
}

