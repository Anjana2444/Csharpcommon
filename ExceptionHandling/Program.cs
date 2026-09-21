try
{
    Console.WriteLine("Try Block");
    int a = 22;
    int b = 0;
    int c = a / b;
    //Console.WriteLine(c);

}
catch(FileNotFoundException)
{
    Console.WriteLine("FileNotFoundException");
}
catch(DivideByZeroException)
{
    Console.WriteLine("DivideByZeroException");
}
catch(Exception ex)
{
    Console.WriteLine("Catch Block"+ ex.Message);
}
finally
{
    Console.WriteLine("finally Block");
}


Console.ReadLine();