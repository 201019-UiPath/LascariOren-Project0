using System;
using Lib;
using UI.Menus;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

    #region obj declaration
        //Console.WriteLine("Welcome");
       // Product obj = new Product();
       // Console.WriteLine($"{obj.name} {obj.location}");

       // Customer obj1= new Customer();
       //Console.WriteLine($"{obj1.Name} {obj1.id}");
    #endregion     
    #region List<String>
    //  Console.WriteLine("Please enter loc to remove ");
    //     string l=Console.ReadLine();
    //     Product.Locs.Remove(l);

    // foreach(var Loc in Product.GetLoc()){
    //        Console.WriteLine(Loc);
    #endregion
    #region Dictionary <string int>
    // Console.WriteLine("Product:             Quantity:");
    // foreach(var Pillow in Product.details){
    //     Console.WriteLine($"{Pillow.Key}{Product.details[Pillow.Key]}");

    // }
    #endregion
    #region Menu region
    IMenu startMenu = new MainMenu();
    startMenu.start();
    #endregion
    
       }
}

