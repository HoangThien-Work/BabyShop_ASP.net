using PTWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace PTWEB.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";
        // GET: Cart
        public ActionResult CartItem()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }

        public ActionResult AddItem(int productID, int quantity)
        {
            Model1 db = new Model1();
            var cart = Session["CartSession"];
            var product = db.SAN_PHAM.Where(x => x.soluong == productID).FirstOrDefault();
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(x => x.Product.soluong == productID))
                {
                    foreach (var item in list)
                    {
                        if (item.Product.soluong == productID)
                        {
                            item.Quantity += quantity;
                        }
                    }
                }
                else
                {
                    var item = new CartItem();
                    item.Product = product;
                    item.Quantity = quantity;
                    list.Add(item);
                }
                Session[CartSession] = list;
            }
            else
            {
                var item = new CartItem();
                item.Product = product;
                item.Quantity = quantity;

                var list = new List<CartItem>();
                list.Add(item);
                Session[CartSession] = list;
            }
            return RedirectToAction("CartItem");
        }

        public ActionResult CartInfor()
        {
            Model1 model1 = new Model1();

            var cart = Session["CartSession"];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return PartialView(list);
        }

        public JsonResult Update(string cartModel)
        {
            var jsonCart = new JavaScriptSerializer().Deserialize<List<CartItem>>(cartModel);
            var sessionCart = (List<CartItem>)Session["CartSession"];
            foreach (var item in sessionCart)
            {
                var jsonItem = jsonCart.SingleOrDefault(x => x.Product.masp == item.Product.masp);
                if (jsonItem != null)
                {
                    item.Quantity = jsonItem.Quantity;
                }
            }
            Session["CartSession"] = sessionCart;
            return Json(new
            {
                status = true
            });
        }

        //public JsonResult DeleteItem(int productID)
        //{
        //	var sessionCart = (List<Item>)Session["CartSession"];
        //	Session["CartSession"] = sessionCart;
        //	sessionCart.RemoveAll(x => x.Product.MaSP == productID);
        //	return Json(new
        //	{
        //		status = true, 
        //	}, JsonRequestBehavior.AllowGet);
        //}

        public ActionResult DeleteItem(int soluong)
        {
            List<CartItem> cart = (List<CartItem>)Session["CartSession"];
            int index = isExist(soluong);
            cart.RemoveAt(index);
            Session["CartSession"] = cart;
            return RedirectToAction("CartItem");
        }

        public JsonResult DeleteAll(string cartModel)
        {
            Session["CartSession"] = null;
            return Json(new
            {
                status = true
            });
        }

        private int isExist(int soluong)
        {
            List<CartItem> cart = (List<CartItem>)Session["CartSession"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.soluong.Equals(soluong))
                    return i;
            return -1;
        }
    }
}