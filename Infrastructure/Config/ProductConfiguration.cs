using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> modelBuilder)
    {
        modelBuilder.Property(p => p.Price)
            .HasColumnType("decimal(18,2)");
    }
}