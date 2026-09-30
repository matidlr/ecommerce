namespace Infrastructure.Config;

{     public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> modelBuilder)
        {
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
        }
    }
}