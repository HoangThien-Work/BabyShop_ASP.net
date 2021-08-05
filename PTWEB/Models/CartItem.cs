using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PTWEB.Models
{
    public class CartItem
    {
        public SAN_PHAM Product { get; set; }

        public int Quantity { get; set; }
    }
}