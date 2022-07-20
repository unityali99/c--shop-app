using CodeFirst_Models.Models;
using System.Data.Entity.ModelConfiguration;
namespace CodeFirst_DAL
{
    internal class CategoryConfigs : EntityTypeConfiguration<Category>
    {
        public CategoryConfigs()
        {
            ToTable("Category", "Product");
            this.Property(e => e.Type).HasMaxLength(40).IsRequired();
            this.HasIndex(p => p.Type).IsUnique();
            this.HasMany(e => e.GunListObj)
                .WithRequired(e => e.CategoryObj)
                .HasForeignKey(e => e.CategoryID)
                .WillCascadeOnDelete(false);
        }
    }
}
