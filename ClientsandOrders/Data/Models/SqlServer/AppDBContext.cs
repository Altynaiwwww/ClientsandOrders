using ClientsandOrders.Data.Enteties;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ClientsandOrders.SqlServer
{
    public class AppDBContext : DbContext
   {
        public DbSet<Clients> Client { get; set; }
        public DbSet<Orders> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            base.OnConfiguring(optionsBuilder);
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string? connectionString = config
                .GetConnectionString("ConnectionString");

            optionsBuilder
                .UseSqlServer(connectionString);
        }
      

    }

}
