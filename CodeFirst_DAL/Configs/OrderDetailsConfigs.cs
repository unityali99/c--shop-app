using CodeFirst_Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirst_DAL
{
    internal class OrderDetailsConfigs : EntityTypeConfiguration<OrderDetails>
    {
        public OrderDetailsConfigs()
        {
            ToTable("OrderDetails", "Product");
            this.HasKey(p => p.ID);
            this.Property(p => p.Quantity).IsRequired();
        }
    }
}
