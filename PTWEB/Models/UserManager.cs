using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PTWEB.Models
{
    public class UserManager
    {
        Model1 model = new Model1();
        public Boolean checkUserName(string userName)
        {
            List<KHACHHANG> UserName = (from user in model.KHACHHANGs where user.ten == userName select user).ToList();
            if (UserName.Count == 1)
            {
                return false;
            }
            return true;
        }

        public Boolean checkEmail(string email)
        {
            List<KHACHHANG> UserName = (from user in model.KHACHHANGs where user.email == email select user).ToList();
            if (UserName.Count == 1)
            {
                return false;
            }
            return true;
        }

        public Boolean CheckLogin(string email, string password)
        {
            Model1 db = new Model1();
            KHACHHANG customer = model.KHACHHANGs.SingleOrDefault(p => p.email == email && p.mk == password);
            if (customer != null)
            {
                return true;
            }
            return false;
        }
    }
}