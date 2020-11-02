using System;
using Serilog;
using Lib;
namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
        #region Logging
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .CreateLogger();

            int number = 123;

            Log.Information("Hello Logger Here, heave ho!  {number}", number);
           // Log.Warning("Salutations {number}", number);
           // Log.Error(new ArgumentOutOfRangeExceptionException(),"Salutations");
        #endregion

            Location l = new Location();
           Console.WriteLine("Salutations");
            int action = chooseAction();
            while(action!=0)
            {
                Console.WriteLine("You choose "+action);
        
               
                switch(action)
                {
                    //adds product to inventory
                    case 3:
                    Console.WriteLine("Enter info");
                    String Name = "";
                    String Location = "";
                    Decimal price = 0;
                    Console.WriteLine("Name of product");
                    Name=Console.ReadLine();
                    Console.WriteLine("Location of product");
                    Location=Console.ReadLine();
                    Console.WriteLine("price of product");
                    price=int.Parse(Console.ReadLine());

                    Product newProduct = new Product(Name,Location,price);
                    l.ShoppingCart.Add(newProduct);
                    
                    printInv(l);
                    break;
                    //ordering product
                    case 1:
                        Console.WriteLine("You are ordering a product");
                        printInv(l);
                        Console.WriteLine("Which product would you like to buy? Enter [#]");
                        int ProductChosen = int.Parse(Console.ReadLine());
                        l.Productlist.Add(l.ShoppingCart[ProductChosen]);
                       
                    printShoppingCart(l);
                    break;

                    // checkout
                    case 2:
                    printShoppingCart(l);
                    Console.WriteLine("The total cost of your item is: $"+l.Checkout());
                    break;

                    //default
                    default:
                    break;
                }
                action = chooseAction();
            }
        }
            #region menu methods
            private static void printShoppingCart(Location l)
            {
                for(int i=0;i<l.Productlist.Count;i++)
                {
                    Console.WriteLine("Products you have bought");
                    Console.WriteLine("Product #:"+i +" "+l.ShoppingCart[i]);
                }
            }

            private static void printInv(Location l)
            {
                for(int i=0;i<l.ShoppingCart.Count;i++)
                {
                    Console.WriteLine("Product #:"+i +" "+l.ShoppingCart[i]);
                }
            }
            static public int chooseAction()
            {
                int choice =0;
                Console.WriteLine("Choose action {customer 0-2}, (0) to quit, (1) to order, (2) to see checkout, {Manager ONLY 3} (3) to add inventory ");
                choice  = int.Parse(Console.ReadLine());
                return choice;
            }
         #endregion
        }

}


/*
Product a = new Product();
            Console.WriteLine("Product a is as follows "+a.Name+" "+a.price+" "+a.Location);

            Location l = new Location();
            
            l.ShoppingCart.Add(a);
            l.ShoppingCart.Add(a);

            Console.WriteLine("Shopping Cart value is "+total);
*/