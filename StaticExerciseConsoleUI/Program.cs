using System;

namespace StaticExerciseConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Conversion");
            //Convert Fahrenheit to Celsius
            Console.Write("Enter a Temperature in Fahrenheit to Convert to Celsius: ");                
            double ftemp = TempConverter.FahrenheitToCelsius(double.Parse(Console.ReadLine()));
            Console.WriteLine($"The Celsius Temperature is {ftemp} degrees.");
            Console.WriteLine();

            //Convert Celsius to Fahrenheit
            Console.Write("Enter a Temperature in Celsius to convert to Fahrenheit: ");
            double ctemp = TempConverter.CelsiusToFahrenheit(double.Parse(Console.ReadLine()));
            Console.WriteLine($"The Fahrenheit Temperature is {ctemp} degrees.");
            
        }
    }
}
