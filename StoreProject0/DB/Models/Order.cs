using System;
using System.Collections.Generic;
namespace DB.Models
{
    public class Order
    {
        public Customer user { get; set; }
        public Location location { get; set; }
        public int id { get; set; }
        public List<Product> ShoppingCart { get; set; }
    }
}

