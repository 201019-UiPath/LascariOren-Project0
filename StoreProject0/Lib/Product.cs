using System;
using System.ComponentModel.DataAnnotations;
namespace Lib
{
    public class Product
    {
    [Key]
    
     public string Location { get; set; }
    [Required(ErrorMessage = "location is required")]
     [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
     public string Name { get; set; }
     [Required(ErrorMessage = "name is required")]
     [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
     public decimal price { get; set; }
    public string stuffing {get;set;}

     public Product()
     {
         Location="NA";
         Name="NA";
         price=0.00M;
    
    }

    public Product(string a,string b, decimal c)
    {
        Name=a;
        Location=b;
        price=c;
      
    }

   

    override public string ToString()
    {
        return "Location: "+Location+"  Name: "+Name+"  Price: $"+price;
    }
    
    }

}
