//List<int> numbers = [4, 7, 43, 12, 15, 8, 20];
//Console.WriteLine("List of numbers");
//Loop(numbers);
//Console.WriteLine();

//Console.WriteLine("numbers.Add(18);");
//numbers.Add(18);
//Loop(numbers);
//Console.WriteLine();

//Console.WriteLine("numbers.Insert(1, 23);");
//numbers.Insert(1, 23);
//Loop(numbers);
//Console.WriteLine();

//Console.WriteLine("numbers.Remove(43);");
//numbers.Remove(43);
//Loop(numbers);
//Console.WriteLine();

//Console.WriteLine("numbers.Contains(8);");
//bool flag = numbers.Contains(8);
//Loop(numbers);
//Console.WriteLine(flag);
//Console.WriteLine();

//Console.WriteLine("numbers.IndexOf(18);");
//int elements = numbers.IndexOf(18);
//Loop(numbers);
//Console.WriteLine(elements);
//Console.WriteLine();

//Console.WriteLine("numbers.Count();");
//int total = numbers.Count();
//Loop(numbers);
//Console.WriteLine(total);
//Console.WriteLine();

//Console.WriteLine("numbers.Sort();");
//numbers.Sort();
//Loop(numbers);
//Console.WriteLine();

//Console.WriteLine("numbers.Clear();");
//numbers.Clear();
//Loop(numbers);
//Console.WriteLine();

//Console.ReadLine();

//static void Loop(List<int> numbers)
//{
//    foreach (int i in numbers)
//    {
//        Console.Write($"{i} ");
//    }
//    Console.WriteLine();
//}

//HashSet<int> hashset = new HashSet<int>();
//hashset.Add(0);
//hashset.Add(1);
//hashset.Add(2);
//hashset.Add(1);;
//foreach(int i in hashset)
//{
//    Console.WriteLine(i);
//}

public class GenericMethod<T>
{
    private readonly List<int> _items = [];
    public void Add(T items) => _items.Add(items);
    public List<T> GetAll() => _items;
}