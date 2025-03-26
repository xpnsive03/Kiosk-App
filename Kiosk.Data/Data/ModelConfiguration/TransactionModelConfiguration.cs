using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kiosk.Data.Models;

namespace Kiosk.Data.Data.ModelConfiguration
{
    public class TransactionModelConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            // Configure the primary key
            builder.HasKey(t => t.TransactionId);

            // Configure properties
            builder.Property(t => t.StaffId)
                .IsRequired();

            builder.Property(t => t.TotalAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(t => t.Quantity)
                .IsRequired();

            builder.Property(t => t.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(t => t.ProductId)
                .IsRequired();

            builder.Property(c => c.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            // Configure foreign keys
            builder.HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.StaffId);

            builder.HasOne(t => t.Product)
                .WithMany()
                .HasForeignKey(t => t.ProductId);
        }
    }
}









