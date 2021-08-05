using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTWEB.Models;

namespace PTWEB.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(string ID)
        {
            Model1 db = new Model1();
            SAN_PHAM detail = db.SAN_PHAM.Find(ID);

            return View(detail);
        }

        public ActionResult Category(string ID)
        {
            Model1 db = new Model1();
            List<LOAI_SP> listCat = db.LOAI_SP.ToList();
            return PartialView(listCat);
        }

        public ActionResult ProductCategory(string ID)
        {
            Model1 db = new Model1();
            List<SAN_PHAM> sanphams = db.SAN_PHAM.Where(m => m.maloai == ID).ToList();
            return View(sanphams);
        }
    }
}