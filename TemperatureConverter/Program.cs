using TemperatureConverter;
TempConverter t1 = new TempConverter();
Console.WriteLine(" Enter the temperature in degree:");
string val =Console.ReadLine();
double celsius = double.Parse(val);
Console.WriteLine($"The Temperature in degree is:{celsius}");
double result = t1.tempConverter(celsius);
Console.WriteLine($"The fahrenheit value is:{result}");



