using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aleksanderreisid.Models
{
    public class CountryTrip
    {
        public int ID { get; set; }
        public Trip tripID { get; set; }
        public Country CountryID { get; set; }
    }
}