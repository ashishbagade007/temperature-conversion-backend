using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TemperatureConversion.Models;

namespace TemperatureConversion.BusinessLogic
{
    public interface ITemperatureConversionBLL
    {
        TemperatureValues Eval();
    }
}