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
    public class VisaController : Controller
    {
        private aleksanderreisidContext db = new aleksanderreisidContext();

        // GET: Visa
        public async Task<ActionResult> Index()
        {
            return View(await db.Documents.Where(n => n.PageID == 3).ToListAsync());
        }
    }
}
