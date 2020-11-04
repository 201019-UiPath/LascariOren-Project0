using System;
using Serilog;
using Lib;
namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Salutations, please ignore these dummy unit tests");
         int yy = Add(4,5);
         Console.WriteLine(yy);
         Console.WriteLine(IsOdd(5));
            

        #region Logging
              Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                //.WriteTo.File("log.txt")
                .WriteTo.Console()
                .CreateLogger();
            Log.Information("test");
        #endregion
            Customer c = new Customer();
            

            Location l = new Location();
            int action = chooseAction();
            while(action!=0)
            {
                Console.WriteLine("You choose "+action);
        
               
                switch(action)
                {
                    case 4:
                    Console.WriteLine("Enter name");
                    String id= "";
                    id=Console.ReadLine();
                    Customer customer = new Customer(id);
               

                       

                    break;

                    //adds product to inventory
                    case 3:
                    Console.WriteLine("Enter info");
                    String Name = "";
                    String Location = "";
                    Decimal price = 0;
                    //Decimal quantity = 0;
                    Console.WriteLine("Name of product");
                    Name=Console.ReadLine();
                    Console.WriteLine("Location of product");
                    Location=Console.ReadLine();
                    Console.WriteLine("price of product");
                    price=int.Parse(Console.ReadLine());
                    //Console.WriteLine("Quantity of prodict");
                    //quantity=int.Parse(Console.ReadLine());

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
                Console.WriteLine("Choose action {customer 0-2}, (0) to quit, (1) to order, {Manager ONLY 3} (3) to add inventory");
                choice  = int.Parse(Console.ReadLine());
                return choice;
            }
         #endregion

        #region silly unit tests
         public static int Add(int x, int y)
         {
             return x+y;
         }
         
         public static bool IsOdd(int value)
         {
             return value % 2==1;
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