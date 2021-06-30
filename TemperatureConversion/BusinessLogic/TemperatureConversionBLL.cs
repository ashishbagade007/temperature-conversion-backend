using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TemperatureConversion.Models;

namespace TemperatureConversion.BusinessLogic
{
    public class TemperatureConversionBLL : ITemperatureConversionBLL
    {
        public TemperatureValues tempValSelected { get; set; }
        public TemperatureValues Eval()
        {
            switch (this.tempValSelected.SelectedTemperatureType)
            {
                case TemperatureType.Celsius:
                    this.tempValSelected.Fahrenheit = this.tempValSelected.Celsius.CelsiusToFahrenHeit();
                    this.tempValSelected.Kelvin = this.tempValSelected.Celsius.CelsiusToKelvin();
                    break;
                case TemperatureType.Fahrenheit:
                    this.tempValSelected.Celsius = this.tempValSelected.Fahrenheit.FahrenheitToCelsius();
                    this.tempValSelected.Kelvin = this.tempValSelected.Fahrenheit.FahrenheitToKelvin();
                    break;
                case TemperatureType.Kelvin:
                    this.tempValSelected.Celsius = this.tempValSelected.Kelvin.KelvinToCelsius();
                    this.tempValSelected.Fahrenheit = this.tempValSelected.Kelvin.KelvinToFahrenheit();
                    break;
            }

            return this.tempValSelected;
        }
    }
}