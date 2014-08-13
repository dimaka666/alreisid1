using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using aleksanderreisid.Models;

namespace aleksanderreisid.Controllers
{
    public class ContentsController : Controller
    {
        private aleksanderreisidContext db = new aleksanderreisidContext();

        // GET: Contents
        public ActionResult Index()
        {
            return View(db.Contents.ToList());
        }

    }
}
