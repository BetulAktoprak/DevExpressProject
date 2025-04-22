using System.Data.Entity;
using DevExpressProject.Entities;

namespace DevExpressProject.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppDbContext")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderDetails)
                .WithRequired(od => od.Order)
                .HasForeignKey(od => od.OrderId);
        }
    }

    
    
}
