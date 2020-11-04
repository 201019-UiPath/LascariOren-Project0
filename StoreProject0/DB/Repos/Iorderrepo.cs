using DB.Models;
using System.Collections.Generic;
namespace DB.Repos
{
    public interface Iorderrepo
    {
        void AddCartItem(Product cartItem);

        void AddOrder(Order order);
    }
}

