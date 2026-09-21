
namespace odd_even
{
    internal class _program
    {

        private static readonly object lockObject = new object();
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
                lock (lockObject)
                {
                    Console.WriteLine($"Even Worker Thread: {Thread.CurrentThread.ManagedThreadId}");
                    for (int i = 1; i <= 20; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine($"The even numbers are {i}");
                            Thread.Sleep(1000);
                        }
                    }
                }
            }
            static void odd()
            {
                lock (lockObject)
                {
                    Console.WriteLine($"odd Worker Thread: {Thread.CurrentThread.ManagedThreadId}");
                    for (int i = 1; i <= 20; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine($"The odd numbers are {i}");
                            Thread.Sleep(1000);
                        }
                    }
                }
            }

            Console.Read();

        }

    }
}


