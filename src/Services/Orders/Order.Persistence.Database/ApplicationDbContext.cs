using Microsoft.EntityFrameworkCore;
using Order.Persistence.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Domain.Order> Orders { get; set; }
        public DbSet<Domain.OrderDetail> OrdersDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("Order");

            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder builder)
        {
            new OrderConfiguration(builder.Entity<Domain.Order>());
            new OrderDetailConfiguration(builder.Entity<Domain.OrderDetail>());
        }
    }
}
