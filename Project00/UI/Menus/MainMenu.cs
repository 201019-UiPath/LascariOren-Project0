using ProjLib;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace UI.Menus
{
    /// <summary>
    /// welcome menu
    /// </summary>
    public class MainMenu : IMenu
    {
        public void start(){
            
            
            System.Console.WriteLine("Welcome Customer");
         
            

        }

    public Product GetStuff(){
            Product Product = new Product();
            System.Console.WriteLine("enter Pillow: ");
            Product.name = System.Console.ReadLine();
            System.Console.WriteLine("Enter to order Pillow");
            Product.Order(System.Console.ReadLine());
            System.Console.WriteLine("Product Ordered");
            return Product;
        }
       
    }
}