using Orders.DAL.Models;
using System.Data.Entity;

namespace Orders.DAL
{
    public class OrdersDBContext : DbContext
    {
        public OrdersDBContext() : base("Data Source=DESKTOP-CVLKMS0\\MSSQLSERVER01; Initial Catalog = OrdersDB; Integrated Security = true")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
