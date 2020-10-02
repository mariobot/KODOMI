using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Catalog.Domain;

namespace Catalog.Persistence.Database
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options): base(options) {
            
        }
        
        public DbSet<Product> Products { get; set; }
    }
}
