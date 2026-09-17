using TemperatureConverter;

Console.WriteLine("Temperature Converter!!!");
Converter tempconv = new Converter();
Console.Write("Enter Temperature in celsius: ");
float temp_in_celsius = Convert.ToSingle(Console.ReadLine());
float fahrenheit = tempconv.CelciusToFahrenheit(temp_in_celsius);
tempconv.PrintTemp(temp_in_celsius,fahrenheit);

Console.ReadLine();