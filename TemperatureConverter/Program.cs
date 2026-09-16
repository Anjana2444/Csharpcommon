using TemperatureConverter;
Console.WriteLine("Enter temperature in Celsius:");
float celsiusvalue = Convert.ToSingle(Console.ReadLine());
Converter c1 = new Converter();
float fahrenheitvalue = c1.ConvertToFahrenheit(celsiusvalue);
c1.PrintCelsiusAndFahrenheit(fahrenheitvalue, celsiusvalue);

