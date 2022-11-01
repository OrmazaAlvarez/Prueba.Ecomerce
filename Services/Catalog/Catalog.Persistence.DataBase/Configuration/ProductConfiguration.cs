using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Catalog.Persistence.DataBase.Configuration
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ProductId);
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Description).IsRequired().HasMaxLength(500);

            //Data for test
            var products = new List<Product>();
            var random = new Random();
            for (int c = 1; c<=100; c++)
            {
                products.Add(new Product
                {
                    ProductId = c,
                    Name = $"Product {c}",
                    Description= $"Description for product {c}",
                    Price = random.Next(100,10000)
                });
            }
            entityBuilder.HasData(products);
        }
    }
}