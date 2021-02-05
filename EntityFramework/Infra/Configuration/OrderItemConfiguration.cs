using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Infra.Configuration
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder
                .ToTable("orderitem");

            builder
                .Property(x => x.Price)
                .HasColumnType("numeric(15,2)")
                .IsRequired();

            builder
                .Property(x => x.Quantity)
                .HasColumnType("decimal(10,4)")
                .IsRequired();

            //builder
            //    .HasOne(x => x.Order);

        }
    }
}
