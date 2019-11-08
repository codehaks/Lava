using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Persistance.Configs
{
    class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(f => f.Id).UseHiLo();

            //builder.OwnsOne(f => f.Count);

            builder.OwnsOne(f => f.UnitPrice);

            builder.Ignore(f => f.TotalPrice);
        }
    }
}
