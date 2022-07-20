using System.Data.Entity.ModelConfiguration.Conventions;

namespace CodeFirst_DAL.Conventions
{
    class DateConventions : Convention
    {
        public DateConventions()
        {
            this.Properties().Where(p => p.Name.EndsWith("date") || p.Name.EndsWith("Date"))
                .Configure(c => c.HasColumnType("date"));

            this.Properties().Where(p => p.Name.EndsWith("datetime") || p.Name.EndsWith("DateTime"))
                .Configure(c => c.HasColumnType("datetime2"));
        }
    }
}
