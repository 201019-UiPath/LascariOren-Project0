
using System.Collections.Generic;
namespace DB.Models
{
    public class shoppingcart
    {
        public Customer user { get; set; }
        public List<Citem> cartItems { get; set; }
    }
}
