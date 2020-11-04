using DB.Models;
using System.Collections.Generic;
namespace DB.Repos
{
    public interface Iproductrepo
    {
        void addProduct(Product product);
        Product getProductbyName(string name);
    }
}
