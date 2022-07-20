using CodeFirst_Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirst_DAL
{
    internal class CountryConfigs : EntityTypeConfiguration<Country>
    {
        public CountryConfigs()
        {
            ToTable("Country", "Product");
            this.Property(e => e.CountryName).HasMaxLength(50).IsRequired();
            this.HasIndex(p => p.CountryName).IsUnique();
            this.HasMany(e => e.GunListObj)
                .WithMany(e => e.CountryObj);
        }
    }
}
