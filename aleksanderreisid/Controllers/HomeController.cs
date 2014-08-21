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
            //Берем документы, который относятся к домашней странице. Индекс домашней страницы 0
            var c = db.Documents.Where(n => n.PageID == 0);
            return View(db.Documents.Where(n => n.PageID == 0).ToList());
        }

        public ActionResult About()
        {
            return View();
        }

    }
}