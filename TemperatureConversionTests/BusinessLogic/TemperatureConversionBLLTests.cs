using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TemperatureConversion.BusinessLogic.Tests
{
    [TestFixture()]
    public class TemperatureConversionBLLTests
    {
        [Test()]
        public void TemperatureConversionBLLTestForCelcius()
        {
            var t = A.Fake<Models.TemperatureValues>();
            t.Celsius = 5000;
            t.SelectedTemperatureType = Models.TemperatureType.Celsius;

            Models.TemperatureValues expectedResult = new Models.TemperatureValues { Celsius = 5000, Fahrenheit = 9032, Kelvin = 5273.15 };
            
            var bll = A.Fake<BusinessLogic.ITemperatureConversionBLL>();
            A.CallTo(() => bll.Eval()).Returns(expectedResult);

            var realBll = new BusinessLogic.TemperatureConversionBLL() { tempValSelected = t };
            var result = realBll.Eval();

            Assert.That(result.Fahrenheit, Is.EqualTo(expectedResult.Fahrenheit));
            Assert.That(result.Kelvin, Is.EqualTo(expectedResult.Kelvin));
        }

        [Test]
        public void TemperatureConversionBLLTestForFahrenheit()
        {
            var t = A.Fake<Models.TemperatureValues>();
            t.Fahrenheit = 5000;
            t.SelectedTemperatureType = Models.TemperatureType.Fahrenheit;

            Models.TemperatureValues expectedResult = new Models.TemperatureValues { Celsius = 2760, Fahrenheit = 5000, Kelvin = 3033.15 };

            var bll = A.Fake<BusinessLogic.ITemperatureConversionBLL>();
            A.CallTo(() => bll.Eval()).Returns(expectedResult);

            var realBll = new BusinessLogic.TemperatureConversionBLL() { tempValSelected = t };
            var result = realBll.Eval();

            Assert.That(result.Celsius, Is.EqualTo(expectedResult.Celsius));
            Assert.That(result.Kelvin, Is.EqualTo(expectedResult.Kelvin));
        }

        [Test]
        public void TemperatureConversionBLLTestForKelvin()
        {
            var t = A.Fake<Models.TemperatureValues>();
            t.Kelvin = 5000;
            t.SelectedTemperatureType = Models.TemperatureType.Kelvin;

            Models.TemperatureValues expectedResult = new Models.TemperatureValues { Celsius = 4726.85, Fahrenheit = 8540.330000000002, Kelvin = 5000 };

            var bll = A.Fake<BusinessLogic.ITemperatureConversionBLL>();
            A.CallTo(() => bll.Eval()).Returns(expectedResult);

            var realBll = new BusinessLogic.TemperatureConversionBLL() { tempValSelected = t };
            var result = realBll.Eval();

            Assert.That(result.Celsius, Is.EqualTo(expectedResult.Celsius));
            Assert.That(result.Fahrenheit, Is.EqualTo(expectedResult.Fahrenheit));
        }
    }
}