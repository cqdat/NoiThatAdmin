namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TanThoiEntities : DbContext
    {
        public TanThoiEntities()
            : base("name=TanThoiEntities")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.SEOUrlRewrite)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.CategoryIDParent);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products1)
                .WithOptional(e => e.Category1)
                .HasForeignKey(e => e.CategoryID);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.PriceSale)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.SEOUrlRewrite)
                .IsUnicode(false);
        }
    }
}
