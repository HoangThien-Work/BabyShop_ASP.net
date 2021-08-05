using PTWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTWEB.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterModels model)
        {
            if (ModelState.IsValid)
            {
                Model1 db = new Model1();
                UserManager manager = new UserManager();
                if (manager.checkUserName(model.UserName) && manager.checkEmail(model.Email))
                {
                    KHACHHANG user = new KHACHHANG
                    {
                        kh_id = model.ID,
                        ten = model.UserName,
                        email = model.Email,
                        mk = model.Password,
                        ngaysinh = model.DoB,
                        sdt = model.PhoneNumber,
                        diachi = model.Address
                    };
                    db.KHACHHANGs.Add(user);
                    db.SaveChanges();
                    return View("Success");
                }
                else
                {
                    ModelState.AddModelError("Register", "Username or Email are existed.");
                    return View("");
                }
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModels model)
        {
            Model1 model1 = new Model1();
            UserManager manager = new UserManager();

            if (ModelState.IsValid)
            {
                if (manager.CheckLogin(model.Email, model.Password))
                {
                    Session["user"] = model.Email;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Login", "Username or Password is wrong, please try again!");
                    return View();
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session["user"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}