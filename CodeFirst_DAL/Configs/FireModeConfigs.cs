using CodeFirst_Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirst_DAL
{

    enum enumFireMode
    {
        Single,
        Rapid,
        Auto
    }

    internal class FireModeConfigs : EntityTypeConfiguration<FireMode>
    {
        public FireModeConfigs()
        {
            ToTable("FireMode", "Product");
            this.Property(e => e.Mode).HasMaxLength(30).IsRequired();
            this.HasIndex(p => p.Mode).IsUnique();
            this.HasMany(e => e.GunListObj)
                .WithRequired(e => e.FireModeObj)
                .HasForeignKey(e => e.FireModeID)
                .WillCascadeOnDelete(false);
        }
    }
}
