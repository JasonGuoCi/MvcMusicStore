using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceSample.Entities
{
    public class ReserveSeatRequest
    {
        public string Name { get; set; }
        public int Seat { set; get; }
        public int Row { get; set; }
    }
}