using CodeFirst_Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirst_DAL
{
    internal class GunConfigs : EntityTypeConfiguration<Gun>
    {
        public GunConfigs()
        {
            ToTable("Gun", "Product");
            this.Property(p => p.Name).HasMaxLength(50).IsUnicode(true).IsRequired();
            this.HasIndex(p => p.Name).IsUnique();
            this.Property(p => p.FullInfoURL).HasMaxLength(500).IsUnicode(true).IsOptional();
            this.Property(p => p.IsTested).IsRequired();
            this.Property(p => p.Quantity).IsRequired();
            this.Property(p => p.HasLicense).IsRequired();
            this.Property(p => p.Price).IsRequired();
            this.HasMany(p => p.OrderDetailsObj)
                .WithRequired(p => p.GunObj)
                .HasForeignKey(p => p.GunID)
                .WillCascadeOnDelete(false);
        }
    }
}