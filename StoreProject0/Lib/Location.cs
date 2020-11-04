using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
namespace Lib
{
    public class Location
    {
        public List<Product> Productlist{ get; set; }
        public List<Product> ShoppingCart { get; set; }
        public List<Order> OrderHistory {get;set;}

        [Key]
        public string loc{get;set;}

        public Location()
        {
            Productlist = new List<Product>();
            ShoppingCart= new List<Product>();
            OrderHistory= new List<Order>();
            loc="NA";
        }

public Location(string a)
    {
        loc=a;
     
    }
        

        override public string ToString()
    {
        return "Location: "+loc;
    }


        public decimal Checkout()
        {
            decimal totalcost = 0;

            foreach(var c in ShoppingCart)
            {
                totalcost = totalcost + c.price;
            }
            ShoppingCart.Clear();
            return totalcost;
        }

 
    }
}