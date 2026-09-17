using Calculator;

int i = 0;
Operations op = new Operations();
while(true)
{
    Console.WriteLine("================");
    Console.WriteLine("1.Addition");
    Console.WriteLine("2.Subtraction");
    Console.WriteLine("3.Multiplication");
    Console.WriteLine("4.Division");
    Console.WriteLine("5.Exit");
    Console.WriteLine("================");
    Console.Write("Enter Choice: ");
    i = Convert.ToInt32(Console.ReadLine());
    if (i == 1)
    {
        Console.WriteLine("Addition");
        Console.Write("Number 1: ");
        op.num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number 2: ");
        op.num2 = Convert.ToInt32(Console.ReadLine());
        float result=op.Addition(op.num1, op.num2);
        op.PrintSum(result);
    }
    else if (i == 2)
    {
        Console.WriteLine("Subtraction");
        Console.Write("Number 1: ");
        op.num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number 2: ");
        op.num2 = Convert.ToInt32(Console.ReadLine());
        float result = op.Subtraction(op.num1, op.num2);
        op.PrintSum(result);
    }
    else if (i == 3)
    {
        Console.WriteLine("Multiplication");
        Console.Write("Number 1: ");
        op.num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number 2: ");
        op.num2 = Convert.ToInt32(Console.ReadLine());
        float result = op.Multiplication(op.num1, op.num2);
        op.PrintSum(result);
    }
    else if (i == 4)
    {
        Console.WriteLine("Division");
        Console.Write("Number 1: ");
        op.num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number 2: ");
        op.num2 = Convert.ToInt32(Console.ReadLine());
        float result = op.Division(op.num1, op.num2);
        op.PrintSum(result);
    }
    else if (i == 5)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Invalid Choice!!!");
    }
}