using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.DataBase
{
    public class CatalogDbContext: DbContext
    {
        public DbSet<ProductCatalog.Domain.Products.Product> Products { get; set; }

        public DbSet<ProductCatalog.Domain.Products.Image> Images{ get; set;}
        public DbSet<ProductCatalog.Domain.Products.Specification> Specifications { get; set; }
        public DbSet<ProductCatalog.Domain.Customers.User> User { get; set; }
        public DbSet<ProductCatalog.Domain.Customers.UserAddress> UserAddress { get; set; }

        public DbSet<ProductCatalog.Domain.Customers.UserLocation> UserLocation { get; set; }

        public DbSet<ProductCatalog.Domain.Role.Roles> Role { get; set; }

        public DbSet<ProductCatalog.Domain.Order.PaymentDetails> PaymentDetails { get; set; }

        public DbSet<ProductCatalog.Domain.Order.OrderDetails> OrderDetails { get; set; }

        public DbSet<ProductCatalog.Domain.Order.OrderStatus> OrderStatus { get; set; }

        public DbSet<ProductCatalog.Domain.Products.Master> Master { get; set; }



        public DbSet<ProductCatalog.Domain.Order.CatalogOrder> CatalogOrder { get; set; }

        public DbSet<ProductCatalog.Domain.Cart.CartItem> CartItem { get; set; }


        public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //method for seed data to database
            modelBuilder.Seed();
        }
    }
}
