internal class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Parallel Invoke!!!");
        Parallel.Invoke(
            () => DoWork("Task A", 1500),
            () => DoWork("Task B", 1000),
            () => DoWork("Task C", 2000)
        );
        Console.WriteLine("All Task Completed!!!");
    }
    static void DoWork(string text, int timeout)
    {
        Console.WriteLine($"{text} started on thread: {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(timeout);
        Console.WriteLine($"{text} finished.");
    }
}