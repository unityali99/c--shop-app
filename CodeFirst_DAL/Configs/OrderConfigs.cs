using CodeFirst_Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirst_DAL
{
    internal class OrderConfigs : EntityTypeConfiguration<Order>
    {
        public OrderConfigs()
        {
            ToTable("Orders", "Product");
            this.HasKey(p => p.ID);
            this.Property(p => p.IsPaid).IsRequired();
            this.HasMany(p => p.orderDetailsObj)
                .WithRequired(p => p.OrderObj)
                .HasForeignKey(p => p.OrderID)
                .WillCascadeOnDelete(false);
            this.HasRequired(p => p.PersonObj)
                .WithMany(p => p.OrderObj)
                .HasForeignKey(p => p.PersonID)
                .WillCascadeOnDelete(false);
        }
    }
}
