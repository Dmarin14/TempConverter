using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp1 = TempConvert.FahrenheitToCelsius(98);
            double temp2 = TempConvert.CelsiusToFahrenheit(98);


            Console.WriteLine($"Fahrenheit to Celsius: {temp1}\nCelsius To Fahrenheit: {temp2}");
            Console.ReadLine();
        }
    }
}
