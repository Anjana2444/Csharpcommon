using Tempconverter;

Console.WriteLine("Temperature Converter");

tempconverter t1 = new tempconverter(36);

float c_k = t1.settemperatureinKelvin(1.8f, 32f);
Console.WriteLine($"Temperature in Fahrenheit: {c_k} ");

Console.Read();