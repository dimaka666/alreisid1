using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aleksanderreisid.Models
{
    public class Trip
    {
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public string CountriesTemp { get; set; }
        public string Description { get; set; }

        public List<City> Cities { get; set; }
    }

}