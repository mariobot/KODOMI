using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductInStockConfiguration
    {
        public ProductInStockConfiguration(EntityTypeBuilder<ProductinStock> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ProductInStockId);

            // Seed Data
            var productsStock = new List<ProductinStock>();
            var random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                productsStock.Add(                
                    new ProductinStock(){
                        ProductId = i,
                        ProductInStockId = i,
                        Stock = random.Next(0, 100)
                });
            }

            entityBuilder.HasData(productsStock);
        }
    }
}
