using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Catalog.Domain;
using Catalog.Persistence.Database.Configuration;

namespace Catalog.Persistence.Database
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options): base(options) {            
        }        
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductinStock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("Catalog");

            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder builder)
        {
            new ProductInStockConfiguration(builder.Entity<ProductinStock>());
            new ProductConfiguration(builder.Entity<Product>());
        }
    }
}
