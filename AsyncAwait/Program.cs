using System.Data.SqlTypes;

internal class Program
{
    static async Task Main(String[] args)
    {
        Console.WriteLine($"Main ID: {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine("Task Started!!!");
        Task task_a = (DoWork(7000, "A"));
        Task task_b = (DoWork(5000, "B"));
        Task task_c = (DoWork(2000, "C"));
        //await Task.WhenAll(task_a, task_b, task_c); //Simultaneously
        await Task.WhenAny(task_a, task_b, task_c); //Any one task
        //await DoWork(5000,"A");
        //await DoWork(2000,"B");
        //await DoWork(3000,"C");
        Console.WriteLine("Task Finished!!!");
        //Console.WriteLine($"Main ID: {Thread.CurrentThread.ManagedThreadId}");
        Console.ReadLine();
    }
    static async Task DoWork(int delay, string work_type)
    {
        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine($"Work Type {work_type} Started");
        await Task.Delay(delay);
        Console.WriteLine($"Work Type {work_type} Finished");
        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
    }
}