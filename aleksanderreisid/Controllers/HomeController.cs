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
    public class HomeController : Controller
    {
        private aleksanderreisidContext db = new aleksanderreisidContext();

        // GET: Contents
        public ActionResult Index()
        {
            return View(db.Contents.Where(n => n.Page == 1 || n.Page == 2 || n.Page == 0).ToList());
        }

        public ActionResult About()
        {
            return View(db.Contents.Where(n => n.Page == 5).ToList());
        }

    }
}