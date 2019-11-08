using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Persistance.Configs
{
    public class FoodConfig : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(f => f.Id).UseHiLo();

            builder.Property(f => f.Name).HasMaxLength(25).IsRequired();
            builder.HasIndex(f => f.Name).IsUnique();
            builder.Property(f => f.Description).HasMaxLength(1000).IsRequired();
            builder.OwnsOne(f => f.Price);

        }
    }
}
