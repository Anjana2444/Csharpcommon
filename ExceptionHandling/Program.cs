try
{
    Console.WriteLine("Try Block");
    int a = 8;
    int b = 0;
    int c = a / b;
}
catch (FileNotFoundException)
{
    Console.WriteLine("FileNotFoundException");
}
catch (DivideByZeroException)
{
    Console.WriteLine("DivideByZeroException");
}
catch (Exception ex)
{
    Console.WriteLine("Catch Block" + ex.Message);
}
finally
{
    Console.WriteLine("Finally Block");
}

Console.ReadLine();