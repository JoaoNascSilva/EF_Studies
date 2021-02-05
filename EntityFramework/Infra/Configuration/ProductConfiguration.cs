using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EntityFramework.Infra.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("product");
            builder.HasKey(x => x.Id);
            builder
                .Property(x => x.Description)
                .HasColumnType("varchar(60)")
                .IsRequired();

            builder
                .Property(x => x.Price)
                .HasColumnType("numeric(15,4)")
                .IsRequired();

            builder
                .Property(x => x.IsActive)
                .HasColumnType("bool")
                .IsRequired();

            builder
                .HasIndex(x => x.Id)
                .HasDatabaseName("idx_product_id");
        }
    }
}
