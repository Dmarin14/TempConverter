using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    internal static class TempConvert
    {


        public static double FahrenheitToCelsius(double d)
        {
            return (d - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double d)
        {
            return d * 5 / 9 + 32;
        }
    }
}
