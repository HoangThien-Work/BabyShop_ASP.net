using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTWEB.Models;

namespace PTWEB.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Index()
        {
            List<SAN_PHAM> sanphams = db.SAN_PHAM.ToList();

            return View(sanphams);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}