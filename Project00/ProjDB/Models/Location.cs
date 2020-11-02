using System.Collections.Generic;
namespace ProjDB
{
    public class Location
    {
    public List<Product> Product { get; set; }
    public List<Product> ShoppingList {get;set;}

    public Location()
    {
    Product = new List<Product>();
    ShoppingList = new List<Product>();
    }

    public decimal Checkout()
    {
        //init total cost
        decimal totalCost = 0;

        foreach(var c in ShoppingList)
        {
            totalCost = totalCost +c.Price;
        }
        ShoppingList.Clear();
        return totalCost;
    }

    }
}