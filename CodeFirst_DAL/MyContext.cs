using CodeFirst_DAL.Conventions;
using CodeFirst_DAL.DB_Initializer;
using CodeFirst_Models.Models;
using System.Data.Entity;

namespace CodeFirst_DAL
{
    public class MyContext : DbContext
    {
        public virtual DbSet<Gun> Guns { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<FireMode> FireModes { get; set; }

        public virtual DbSet<Person> Persons { get; set; }

        public virtual DbSet<Account> Accounts { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderDetails> OrderDetails { get; set; }

        public MyContext()
        {
            Database.SetInitializer<MyContext>(new DBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GunConfigs());
            modelBuilder.Configurations.Add(new FireModeConfigs());
            modelBuilder.Configurations.Add(new CategoryConfigs());
            modelBuilder.Configurations.Add(new CountryConfigs());
            modelBuilder.Configurations.Add(new PersonConfigs());
            modelBuilder.Configurations.Add(new AccountConfigs());
            modelBuilder.Configurations.Add(new OrderConfigs());
            modelBuilder.Configurations.Add(new OrderDetailsConfigs());
            modelBuilder.Conventions.Add(new IDConventions());
            modelBuilder.Conventions.Add(new DateConventions());
            modelBuilder.HasDefaultSchema("DB");
        }
    }
}
