using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kiosk.Data.Models;

namespace Kiosk.Data.Data.ModelConfiguration
{
    public class CustomerModelConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Configure the primary key
            builder.HasKey(c => c.CustomerId);

            // Configure properties
            builder.Property(c => c.Name)
                .HasMaxLength(100);

            builder.Property(c => c.Email)
                .HasMaxLength(100);

            builder.Property(c => c.ContactNumber)
                .HasMaxLength(15);

            builder.Property(c => c.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(c => c.OrderId)
                .IsRequired();

            // Configure foreign key
            builder.HasOne(c => c.Order)
                .WithMany()
                .HasForeignKey(c => c.OrderId);
        }
    }
}
