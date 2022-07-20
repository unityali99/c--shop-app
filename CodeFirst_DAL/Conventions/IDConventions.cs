using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CodeFirst_DAL
{
    internal class IDConventions : Convention
    {
        public IDConventions()
        {
            this.Properties().Where(p => p.Name.Equals("ID"))
                .Configure(c =>
                    {
                        c.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                    }
                );
        }
    }
}