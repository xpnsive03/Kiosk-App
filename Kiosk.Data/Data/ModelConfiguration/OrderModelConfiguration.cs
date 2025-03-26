using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kiosk.Data.Models;

namespace Kiosk.Data.Data.ModelConfiguration
{
    public class OrderModelConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            // Configure the primary key
            builder.HasKey(o => o.OrderId);

            // Configure properties
            builder.Property(o => o.OrderDate)
                .IsRequired();

            builder.Property(o => o.TotalAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(o => o.StaffId)
                .IsRequired();

            builder.Property(o => o.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(o => o.OrderItemsId)
                .IsRequired();

            // Configure foreign keys
            builder.HasOne(o => o.User)
                .WithMany()
                .HasForeignKey(o => o.StaffId);

            builder.HasOne(o => o.OrderItem)
                .WithMany()
                .HasForeignKey(o => o.OrderItemsId);
        }
    }
}
