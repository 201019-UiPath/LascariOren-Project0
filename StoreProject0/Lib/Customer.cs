using System;
using System.Collections.Generic;
namespace Lib
{
    public class Customer
    {
        public string id{get;set;}
        public string name{get;set;}
    
         public List<Order> Orderlist { get; set; }
         public List<Location> inv {get;set;}

    public Customer()
     {
         id="NA";
    }

    public Customer(string a)
    {
        id=a;
    }

    }
}