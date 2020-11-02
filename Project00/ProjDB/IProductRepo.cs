using ProjDB.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ProjDB
{
    public interface IProductRepo
    {
         Task<List<Product>> GetAllProductsAsync();
         void AddAProductAsync(Product hero);
         Product GetProductByName(string name);
    }
}