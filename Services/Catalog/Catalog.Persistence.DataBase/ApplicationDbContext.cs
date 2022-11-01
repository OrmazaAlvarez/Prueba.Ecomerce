using Microsoft.EntityFrameworkCore;
using Catalog.Domain;
using Catalog.Persistence.DataBase.Configuration;

namespace Catalog.Persistence.DataBase
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder builder)
        {
            new ProductConfiguration(builder.Entity<Product>());
            new StockConfiguration(builder.Entity<Stock>());
        }
    }
}
