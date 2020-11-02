using System.Collections.Generic;

namespace ProjLib


{
    
    public class Product
    {
        public string name { get; set; }
        public string location {get; set;}
        public int price {get; set;}
        public string history{get; set;}
        public int quantity{get; set;}

    public static List<string> Locs = new List<string>();
    public static Dictionary<string, int> details= new Dictionary<string, int>();

    public Product()
    {
        Locs.Add("Place 1");
        Locs.Add("Place 2");
        Locs.Add("Place 3");

        details.Add("Soft Pillow          $", 33);
        details.Add("Big Pillow           $", 40);
        details.Add("Hard Pillow          $", 45);
    }
    public static List<string> GetLoc()
    {
        
        return Locs;
    }

    public static void Remove(string Loc){
        if(Locs.Contains(Loc)){
            Locs.Remove(Loc);
        }
    }

    public static void Order(string Loc){
        if(Locs.Contains(Loc)){
            Locs.Add(Loc);
        }
    }
    
    
/*        
 public Product GetStuff(){
            Product Product = new Product();
            System.Console.WriteLine("enter Pillow: ");
            Product.name = System.Console.ReadLine();
            System.Console.WriteLine("Enter to order Pillow");
            Product.Order(System.Console.ReadLine());
            System.Console.WriteLine("Product Ordered");
            return Product;
        }
*/


/*
    public Product(int price){
        name="product1";
        location="CA";
        price=4;
        history="N/A";
        quantity=5;
    }
*/
    }
}