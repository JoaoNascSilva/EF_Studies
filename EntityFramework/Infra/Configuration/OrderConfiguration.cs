using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Infra.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("order");
            builder.HasKey(x => x.Id);
            //builder
            //    .Property(x => x.CreateDate)
            //    .HasColumnType("DateTime")
            //    .IsRequired();

            builder
                .Property(x => x.Description)
                .HasColumnType("varchar(120)")
                .HasMaxLength(120)
                .IsRequired();

            builder
                .HasMany(x => x.OrderItens)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.IdOrder);
        }
    }
}
