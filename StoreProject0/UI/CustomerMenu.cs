using System;
using DB;
using DB.Models;
using Lib;
using System.Collections.Generic;
namespace UI
{
    public class CustomerMenu : IMenu
    {
        public void start()
        {
            Console.WriteLine("Howdy");
        }

      //  private Location location = new Location();

        private void dummydata()
        {
           // Location.Product.Add(new Product){}
           Console.WriteLine("DUmmy");
        }
    }
}