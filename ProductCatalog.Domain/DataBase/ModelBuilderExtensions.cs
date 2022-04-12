using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.DataBase
{
    public static class ModelBuilderExtensions
    {
        /// <summary>
        /// Extension Class for OnModelCreating Method to seed initial data to database
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products.Master>().HasData(
                new Products.Master
                {
                    Id = 1,
                    name = "ProductType",
                    Description = "NULL",

                    ParentId = Products.MasterId.ProductType
                }
                );
            modelBuilder.Entity<Products.Master>().HasData(
                new Products.Master
                {
                    Id = 2,
                    name = "ProductBrand",
                    Description = "NULL",

                    ParentId = Products.MasterId.ProductType
                }
                );

            modelBuilder.Entity<Products.Master>().HasData(
                new Products.Master
                {
                    Id = 3,
                    name = "Color",
                    Description = "NULL",

                    ParentId = Products.MasterId.ProductType
                }
                );

            modelBuilder.Entity<Products.Master>().HasData(
                new Products.Master
                {
                    Id = 4,
                    name = "Storage",
                    Description = "NULL",

                    ParentId = Products.MasterId.ProductType
                }
                );

            modelBuilder.Entity<Products.Master>().HasData(
                new Products.Master
                {
                    Id = 5,
                    name = "SimType",
                    Description = "NULL",

                    ParentId = Products.MasterId.ProductType
                }
                );

            modelBuilder.Entity<Products.Master>().HasData(
                new Products.Master
                {
                    Id = 6,
                    name = "OperatingSystem",
                    Description = "NULL",

                    ParentId = Products.MasterId.ProductType
                }
                );

            modelBuilder.Entity<Products.Master>().HasData(
                new Products.Master
                {
                    Id = 7,
                    name = "ProcessorType",
                    Description = "NULL",

                    ParentId = Products.MasterId.ProductType
                }
                );

            modelBuilder.Entity<Products.Master>().HasData(
               new Products.Master
               {
                   Id = 8,
                   name = "ProcessorCore",
                   Description = "NULL",

                   ParentId = Products.MasterId.ProductType
               }
               );

            modelBuilder.Entity<Products.Master>().HasData(
               new Products.Master
               {
                   Id = 9,
                   name = "PrimaryCamera",
                   Description = "NULL",

                   ParentId = Products.MasterId.ProductType
               }
               );
        }
    }
}
