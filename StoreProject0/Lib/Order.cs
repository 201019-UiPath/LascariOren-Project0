using DB.Models;
using DB.Repos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
namespace Lib
{
    public class Order
    {
        [Key]
        public string name {get;set;}

        public List<Product> Orderdetails { get; set; }
        
    }
}

