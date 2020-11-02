using System.Collections.Generic;
namespace Lib
{
    public class Location
    {
        public List<Product> Productlist{ get; set; }
        public List<Product> ShoppingCart { get; set; }

        public Location()
        {
 
            Productlist = new List<Product>();
            ShoppingCart= new List<Product>();

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