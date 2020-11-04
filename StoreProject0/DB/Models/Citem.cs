using System;
using System.Collections.Generic;
using System.Text;
namespace DB.Models
{
    public class Citem
    {
        public int id { get; set; }
        public shoppingcart cart { get; set; }

        public Product product {get; set;}
    }
}



