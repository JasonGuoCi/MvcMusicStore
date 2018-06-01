using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceSample.Entities
{
    public class ReserveSeatResponse
    {
        public string Name { get; set; }
        public int Row { get; set; }
        public int Seat { get; set; }
    }
}