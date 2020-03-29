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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.SEOUrlRewrite)
                .IsUnicode(false);
        }
    }
}
