using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServiceSample.Entities;

namespace WebServiceSample
{
    /// <summary>
    /// Summary description for SampleService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SampleService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        /// <summary>
        /// 字符串反转
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        [WebMethod]
        public string ReverseString(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        [WebMethod]
        public GetWeatherResponse GetWeature(GetWeatherRequest req)
        {
            var resp = new GetWeatherResponse();
            var r = new Random();

            int celsius = r.Next(-20, 50);

            if (req.TemperatureType == TemperatureType.Celsius)
            {
                resp.Temperature = celsius;
            }
            else
            {
                resp.Temperature = (212 - 32) / 100 * celsius + 32;
            }

            if (req.City == "Redmond")
            {
                resp.Condition = TemperatureCondition.Rainy;
            }
            else
            {
                resp.Condition = (TemperatureCondition)r.Next(0, 3);
            }

            return resp;
        }
    }
}
