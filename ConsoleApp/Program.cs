#region Call Type
//Value Type
void Value1(int val1)
{
    val1 = 100;
}
int num1 = 10;
Value1(num1);

//Refence Type using ref
void Value2(ref int val2)
{
    val2 = 100;
}
int num2 = 10;
Value2(ref num2);

//Refence Type using out
void Value3(out int val3)
{
    val3 = 100;
}
int num3;
Value3(out num3);

//Refence Type using in
void Value4(in int val4)
{
    //val value can't be changed
}
int num4 = 10;
Value4(num4);

Console.WriteLine(num4);
Console.ReadLine();
#endregion
#region Normal Delegate
int Add(int x, int y)
{
    return x + y;
}
int Multiply(int x, int y)
{
    return x * y;
}
void DisplayResult(Calculate calculate, int x, int y)
{
    Console.WriteLine(calculate(x, y));
}

Calculate add_calculate = Add;
Calculate mul_calculate = Multiply;

DisplayResult(add_calculate, 5, 7);
DisplayResult(mul_calculate, 5, 9);

Console.ReadLine();
#endregion
#region Tuple Type Function
(string, int) MultipleReturn() // Returning multiple data type values values
{
    return ("Antony", 21);
}
string name = MultipleReturn().Item1;
int age = MultipleReturn().Item2;
(string name1, int age1) = MultipleReturn();
var full_details = MultipleReturn();
Console.WriteLine($"Name: {name}, Age: {age}");
Console.WriteLine($"Name: {name1}, Age: {age1}");
Console.WriteLine($"Full Details: {full_details}");
Console.ReadLine();
#endregion
#region Name Normal Delegate
string CombineString(string first_name, string last_name)
{
    return first_name + " " + last_name;
}
CombineDel combining = CombineString;
string full_name = combining("1. Antony", "Jacob");
Console.WriteLine(full_name);
Console.ReadLine();
#endregion
#region Name Anonymous Delegate
CombineDel combining1 = delegate (string first_name1, string last_name1) // Anonymous Delegate
{
    return first_name1 + " " + last_name1;
};
string full_name1 = combining1("2. Antony", "Jacob");
Console.WriteLine(full_name1);
Console.ReadLine();
#endregion
#region Name Lamda Anonymous Delegate
CombineDel combining2 = (first_name2, last_name2) =>first_name2 + " " + last_name2; // Lmada Expression
string full_name2 = combining2("3. Antony", "Jacob");
Console.WriteLine(full_name2);
Console.ReadLine();
public delegate string CombineDel(string x, string y);
public delegate int Calculate(int val1, int val2);
#endregion