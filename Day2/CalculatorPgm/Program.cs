using CalculatorPgm;

Console.WriteLine("Enter first number:");
float number1 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");
float number2 = float.Parse(Console.ReadLine());

Calculator c1 = new Calculator(number1,number2);

c1.PrintDetails();

float addition=c1.Add();
Console.WriteLine($"Addition: {addition}");

float subtraction = c1.Sub();
Console.WriteLine($"Addition: {subtraction}");

float multiplication = c1.Mult();
Console.WriteLine($"Addition: {multiplication}");

float division = c1.Div();
Console.WriteLine($"Addition: {division}");

Console.ReadLine();
