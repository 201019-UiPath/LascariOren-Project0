using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace Lib
{
    public class MyWebApiContext : DbContext
    {
      

        public DbSet<Product> Product {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
               if(!(optionsBuilder.IsConfigured))
            {
                var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                var connectionString = configuration.GetConnectionString("MyWebApiContext");
                optionsBuilder.UseNpgsql(connectionString);
            }
        }
    }
}