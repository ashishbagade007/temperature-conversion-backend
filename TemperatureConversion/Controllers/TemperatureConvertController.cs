using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TemperatureConversion.Models;
using TemperatureConversion.BusinessLogic;

namespace TemperatureConversion.Controllers
{
    public class TemperatureConvertController : ApiController
    {
        //// GET: api/TemperatureConvert
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/TemperatureConvert/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/TemperatureConvert
        public TemperatureValues Post([FromBody]TemperatureValues value)
         {
            TemperatureConversionBLL bll = new TemperatureConversionBLL() { tempValSelected = value };
            var tempVal = bll.Eval();
            return tempVal;
        }

        //// PUT: api/TemperatureConvert/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/TemperatureConvert/5
        //public void Delete(int id)
        //{
        //}
    }
}
