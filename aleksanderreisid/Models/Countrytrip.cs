using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aleksanderreisid.Models
{
    public class CountryTrip
    {
        public int ID { get; set; }
        public virtual Trip Trip { get; set; }
        public virtual Country Country { get; set; }
    }
}