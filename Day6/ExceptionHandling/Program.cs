try
{
    Console.WriteLine("Try block");
    int a = 8;
    int b = 0;
    int c = a / b;    
}
catch (DivideByZeroException)
{
    Console.WriteLine("Divide by zero exception");
}
catch(Exception ex)
{
    Console.WriteLine("Catch Block" + " "+ex.Message);
}
finally
{
    Console.WriteLine("Finally block");
}


//Console.WriteLine(c);
Console.ReadLine();
