using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemperatureConversion.BusinessLogic
{
    public static class TemperatureExtensionMethods
    {
        public static double CelsiusToFahrenHeit(this double input)
        {
            return (((input * 9d) / 5d) + 32);
        }
        public static double CelsiusToKelvin(this double input)
        {
            return (input += 273.15);
        }
        public static double FahrenheitToCelsius(this double input)
        {
            return ((input - 32) * (5d / 9d));
        }
        public static double FahrenheitToKelvin(this double input)
        {
            return ((((input - 32)) * (5d / 9d)) + 273.15);
        }
        public static double KelvinToCelsius(this double input)
        {
            return (input -= 273.15);
        }
        public static double KelvinToFahrenheit(this double input)
        {
            return (((input - 273.15) * (9d / 5d)) + 32);
        }
    }
}