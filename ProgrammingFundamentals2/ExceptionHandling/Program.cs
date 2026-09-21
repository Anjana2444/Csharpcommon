try
{
    Console.WriteLine("Try block 1");
    int a, b;
    b = 0; // only available inside try{} block
    a = 16; // only available inside try{} block 
    int c = a / b;
    Console.WriteLine("Try block 2");
}
catch(FileNotFoundException)
{
    Console.WriteLine("File Not Found Exception");
}
catch(DivideByZeroException ey)
{
    Console.WriteLine("Divide By Zero Exception " + ey.Message);
}

catch(Exception ex)
{
    Console.WriteLine("Catch block " + ex.Message);
}
finally
{
    Console.WriteLine("Final block");
}

Console.ReadLine();
