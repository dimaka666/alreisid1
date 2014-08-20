using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using aleksanderreisid.Models;

namespace aleksanderreisid.Controllers
{
    public class TripController : Controller
    {
        private aleksanderreisidContext db = new aleksanderreisidContext();
        // GET: Trip
        public ActionResult Index(string sortOrder, string startDateFilter)
        {
            Dictionary<int, List<City>> citytripCon = new Dictionary<int, List<City>>();

            ViewBag.CurrentSort = sortOrder;
            ViewBag.PriceSortParam = String.IsNullOrEmpty(sortOrder) ? "price_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            //var trips = db.trips;
            var trips = from n in db.trips select n;
            switch (sortOrder)
            {
                case "price_desc":
                    trips = trips.OrderByDescending(n => n.Price);
                    break;
                default:  // Name ascending 
                    trips = trips.OrderBy(n => n.Price);
                    break;
            }
            if(startDateFilter != "")
            {
                DateTime datefilter = Convert.ToDateTime(startDateFilter);
                trips = trips.Where(t => t.StartDate >= datefilter);
            }
            var cities = db.cities;
     
          
          /** foreach (var t in trips)
            {
                List<int> ids = new List<int>(db.citytrips.Where(i => i.Trip == t.ID).Select(i => i.City));
                List<City> citiesList = new List<City>(db.cities.Where(c => ids.Contains(c.ID)));
                citytripCon.Add(t.ID, citiesList);
            }**/
            return View(trips.ToList());
        }

    }
}
