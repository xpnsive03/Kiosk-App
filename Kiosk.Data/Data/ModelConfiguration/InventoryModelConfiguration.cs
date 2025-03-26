using Kiosk.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kiosk.Data.Data.ModelConfiguration
{
    public class InventoryModelConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            // Configure the primary key
            builder.HasKey(i => i.InventoryId);

            // Configure properties
            builder.Property(i => i.ProductId)
                .IsRequired();

            builder.Property(i => i.DeliveryDateAndTime)
                .IsRequired();

            builder.Property(i => i.Supplier)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(i => i.Quantity)
                .IsRequired()
                .HasDefaultValue(1);

            builder.Property(i => i.Status)
                .IsRequired()
                .HasMaxLength(50);

            // Configure foreign key
            builder.HasOne(i => i.Product)
                .WithMany()
                .HasForeignKey(i => i.ProductId);
        } 
    }
}
