using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kiosk.Data.Models;

namespace Kiosk.Data.Data.ModelConfiguration
{
    public class SupplierModelConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            // Configure the primary key
            builder.HasKey(s => s.SupplierId);

            // Configure properties
            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.ContactNumber)
                .HasMaxLength(15);

            builder.Property(s => s.Email)
                .HasMaxLength(100);

            builder.Property(s => s.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(s => s.Address)
                .HasMaxLength(200);

            builder.Property(s => s.ProductId)
                .IsRequired();

            // Configure foreign key
            builder.HasOne(s => s.Product)
                .WithMany()
                .HasForeignKey(s => s.ProductId);
        }
    }
}









