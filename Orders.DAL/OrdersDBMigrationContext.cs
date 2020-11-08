using Orders.DAL.Models;
using System.Data.Entity;

namespace Orders.DAL
{
    public class OrdersDBMigrationContext : DbContext
    {
        public OrdersDBMigrationContext() : base("Data Source=DESKTOP-CVLKMS0\\MSSQLSERVER01; Initial Catalog = OrdersMigrationDB; Integrated Security = true")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasRequired(x => x.Product)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<Order>()
                .HasRequired(x => x.User)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.UserId);
        }
    }
}
