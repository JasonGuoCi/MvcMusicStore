using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceSample.Entities
{
    public class GetWeatherRequest
    {
        public string City
        {
            get; set;
        }

        public TemperatureType TemperatureType { get; set; }
    }

    public enum TemperatureType
    {
        Fahrenheit,
        Celsius
    }
}