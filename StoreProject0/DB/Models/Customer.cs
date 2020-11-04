using System;
using System.Collections.Generic;
using System.Text;
namespace DB.Models
{
    public class Customer
    {
            public int id { get; set; }
            public List<Order> orders { get; set; }
    }
}