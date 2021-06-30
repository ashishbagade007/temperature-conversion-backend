using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemperatureConversion.Models
{
    public class TemperatureValues
    {
        public double Celsius { get; set; }

        public double Fahrenheit { get; set; }

        public double Kelvin { get; set; }
        public TemperatureType SelectedTemperatureType { get; set; }
    }

    public enum TemperatureType
    {
        None = 0,
        Celsius,
        Fahrenheit,
        Kelvin
    }
}