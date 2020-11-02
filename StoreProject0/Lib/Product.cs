using System;
using System.ComponentModel.DataAnnotations;
namespace Lib
{
    public class Product
    {
    [Key]
    [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
     public string Location { get; set; }
     
    [StringLength(60, MinimumLength = 3)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
     public string Name { get; set; }
    [Range(1, 100)]
    [DataType(DataType.Currency)]
     public decimal price { get; set; }

    

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
