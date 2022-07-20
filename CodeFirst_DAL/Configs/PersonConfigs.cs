using CodeFirst_Models.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirst_DAL
{
    internal class PersonConfigs : EntityTypeConfiguration<Person>
    {
        public PersonConfigs()
        {
            this.ToTable("People", "Personal");
            this.HasKey(p => p.PersonID);
            this.Property(p => p.PersonID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Name).IsRequired().IsUnicode(true).HasMaxLength(40);
            this.Property(p => p.LastName).IsRequired().IsUnicode(true).HasMaxLength(55);
            this.Ignore(p => p.FullName);
            this.Property(p => p.SSN).IsRequired().HasMaxLength(10);
            this.HasIndex(p => p.SSN).IsUnique();
            this.Property(p => p.Email).IsRequired().IsUnicode(true).HasMaxLength(70);
            this.HasIndex(p => p.SSN).IsUnique();
            this.HasOptional(obj => obj.AccountObj)
                .WithRequired(obj => obj.PersonObject);
        }
    }
}
