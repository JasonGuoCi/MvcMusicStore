using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceSample.Entities
{
    public class GetWeatherResponse
    {
        public TemperatureCondition Condition { get; set; }
        public int Temperature { get; set; }
    }

    public enum TemperatureCondition
    {
        Rainy,
        Sunny,
        Cloudy,
        ThunderStorm
    }
}