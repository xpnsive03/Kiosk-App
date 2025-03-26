using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kiosk.Data.Models;

namespace Kiosk.Data.Data.ModelConfiguration
{
    public class ProductModelConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Configure the primary key
            builder.HasKey(p => p.ProductId);

            // Configure properties
            builder.Property(p => p.ProductName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.Category)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Description)
                .HasMaxLength(500);

            builder.Property(p => p.ProductImagePath)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}








