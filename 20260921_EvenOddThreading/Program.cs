public class EvenOdd
{
    static int num = 0;
    static int max = 10;
    static readonly object lockObject = new object();
    static void Even()
    {
        Console.WriteLine($"Even Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        while (num <= max)
        {
            lock (lockObject)
            {
                while (num % 2 == 0)
                {
                    Console.WriteLine($"Even: {num}");
                    num++;
                    Thread.Sleep(1000);
                }
            }
        }
    }
    static void Odd()
    {
        Console.WriteLine($"Odd Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        while (num < max)
        {
            lock (lockObject)
            {
                while (num % 2 != 0)
                {
                    Console.WriteLine($"Odd: {num}");
                    num++;
                    Thread.Sleep(1000);
                }
            }
        }
    }
    static void Main(String[] args)
    {
        Console.WriteLine($"Main Thread: {Thread.CurrentThread.ManagedThreadId}");
        Thread even = new Thread(Even);
        Thread odd = new Thread(Odd);
        even.Start();
        odd.Start();

        odd.Join();
        even.Join();
        Console.WriteLine("\nProgram Finsihed");
        Console.ReadLine();
    }
}