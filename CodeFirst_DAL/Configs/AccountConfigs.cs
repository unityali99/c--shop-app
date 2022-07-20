using CodeFirst_Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirst_DAL
{
    internal class AccountConfigs : EntityTypeConfiguration<Account>
    {
        public AccountConfigs()
        {
            ToTable("Account", "Personal");
            this.HasKey(p => p.PersonID);
            this.Property(p => p.UserName).IsRequired().HasMaxLength(1000).IsUnicode(false);
            this.HasIndex(p => p.UserName).IsUnique();
            this.Property(p => p.Password).IsRequired().HasMaxLength(1000).IsUnicode(false);
        }
    }
}
