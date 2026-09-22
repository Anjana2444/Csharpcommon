internal class Program
{
    static void Main(String[] args)
    {
        Task task = Task.Run(DoWork);
        Task<int> task1 = Task.Run(DisplaySum);
        int sum = task1.Result;
        task.Wait();
        Console.WriteLine($"Sum: {sum}");
        task1.Wait();
        Console.WriteLine($"Main Thread: {Thread.CurrentThread.ManagedThreadId}");
        Console.ReadLine();
    }
    static void DoWork()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Number: {i}");
            Task.Delay(1000).Wait();
        }
        Console.WriteLine($"Worker Thread: {Thread.CurrentThread.ManagedThreadId}");
    }
    static int DisplaySum()
    {
        int a = 6, b = 9;
        return a + b;
    }
}