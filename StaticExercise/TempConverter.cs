using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class TempConverter
    {
        public static double FahrenheitToCelsius()
        {
            Console.WriteLine("Please enter a fahrenheit temperature.");
            double f = double.Parse(Console.ReadLine()!);
            double celsius = 5 / 9 * (f - 32);
            return celsius;
            
        }
        public static double CelsiusToFahrenheit(double c)
        {
            double fahrenheit = (c * 9 / 5) + 32;
            return fahrenheit;
        }
    }
}
