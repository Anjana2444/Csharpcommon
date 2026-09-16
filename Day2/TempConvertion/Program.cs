using TempConvertion;

Temperature t1 = new Temperature();
Console.WriteLine("Enter the value to convert");
float temperature = float.Parse(Console.ReadLine());

t1.Value= temperature;
t1.PrintDetails();

float fahrenheit=t1.CelsiusToFahrenheit();
Console.WriteLine($"Temperature in fahrenheit {fahrenheit}");