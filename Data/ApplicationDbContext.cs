using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;

namespace Ecommerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Variation> Variations { get; set; }
        public DbSet<Discount> Discounts { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<DiscountProduct> DiscountProducts { get; set; }
        public DbSet<DiscountVariation> DiscountVariations { get; set; }
        public DbSet<DiscountCategory> DiscountCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductCategory>()
                .HasKey(pc => new { pc.ProductId, pc.CategoryId });

            modelBuilder.Entity<DiscountProduct>()
                .HasKey(dp => new { dp.ProductId, dp.DiscountId });

            modelBuilder.Entity<DiscountVariation>()
                .HasKey(dv => new { dv.VariationId, dv.DiscountId });

            modelBuilder.Entity<DiscountCategory>()
                .HasKey(dc => new { dc.CategoryId, dc.DiscountId });
        }
    }
}
