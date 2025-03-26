using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kiosk.Data.Models;

namespace Kiosk.Data.Data.ModelConfiguration
{
    public class OrderItemModelConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            // Configure the primary key
            builder.HasKey(oi => oi.OrderItemId);

            // Configure properties
            builder.Property(oi => oi.ProductId)
                .IsRequired();

            builder.Property(oi => oi.TotalAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(oi => oi.Quantity)
                .IsRequired();

            builder.Property(oi => oi.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            // Configure foreign key
            builder.HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId);
        }
    }
}







