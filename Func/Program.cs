// Func (delegate more compressed version)
Func<int, int, float> func_add1 = (x, y) => x + y;
Func<int, int, float> func_add2 = (x, y) =>
{
    Console.WriteLine($"First var: {x}\nSecond var: {y}");
    return x + y;
};
float result1 = func_add1(1, 5);
Console.WriteLine(result1 + "\n");
float result2 = func_add2(2, 5);
Console.WriteLine(result2 + "\n");

// Action (Func with no return)
Action<int, int> action_add1 = (x, y) => Console.WriteLine(x + y + "\n");
Action<int, int> action_add2 = (x, y) =>
{
    Console.WriteLine($"First var: {x}\nSecond var: {y}");
    Console.WriteLine(x + y + "\n");
};
action_add1(5, 8);
action_add2(4, 8);

// Predicate (bool return)
Predicate<int> predicate_equal1 = x => x > 5;
Predicate<int> predicate_equal2 = x =>
{
    Console.WriteLine($"Var: {x}");
    return x > 5;
};
bool ans1 = predicate_equal1(2);
Console.WriteLine(ans1 + "\n");
bool ans2 = predicate_equal2(8);
Console.WriteLine(ans2);

Console.ReadLine();