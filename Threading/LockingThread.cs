using System;
using System.Collections.Generic;
using System.Text;

namespace Threading
{
    internal class LockingThread
    {
        static int counter = 0;
        static readonly object lockObject = new object();
        static void Increment()
        {
            for (int i = 0; i < 10000000; i++)
            {
                lock (lockObject)
                {
                    counter++;
                }
            }
        }
        static void Main(String[] args)
        {
            Thread thread1 = new Thread(Increment);
            Thread thread2 = new Thread(Increment);
            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
            Console.WriteLine($"Final Counter Value: {counter}");
        }
    }
}
