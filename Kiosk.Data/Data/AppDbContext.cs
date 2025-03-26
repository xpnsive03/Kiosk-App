using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosk.Data.Data.ModelConfiguration;
using Kiosk.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Kiosk.Data.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply individual model configurations
            modelBuilder.ApplyConfiguration(new UserModelConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerModelConfiguration());
            modelBuilder.ApplyConfiguration(new InventoryModelConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemModelConfiguration());
            modelBuilder.ApplyConfiguration(new OrderModelConfiguration());
            modelBuilder.ApplyConfiguration(new ProductModelConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierModelConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionModelConfiguration());

            // Add other configurations similarly...

            base.OnModelCreating(modelBuilder);
        }
    }
}
