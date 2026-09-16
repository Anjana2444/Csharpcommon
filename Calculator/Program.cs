using Calculator;
Calculation c1 = new Calculation();
Console.WriteLine("Enter the first Number:");
double first_num = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second Number:");
double second_num = double.Parse(Console.ReadLine());
double add_res = c1.addition(first_num, second_num);
Console.WriteLine($"The addition result is:{add_res}");
Console.WriteLine();
double sub_res = c1.subtraction(first_num, second_num);
Console.WriteLine($"The subtracted result is:{sub_res}");
Console.WriteLine();
double mul_res = c1.multiplication(first_num, second_num);
Console.WriteLine($"The multiplication result is:{mul_res}");
Console.WriteLine();
Console.WriteLine();
//double div_res = c1.division(first_num, second_num);
//Console.WriteLine($"The division result is:{div_res}");
//Console.WriteLine();
c1.division(first_num, second_num);







