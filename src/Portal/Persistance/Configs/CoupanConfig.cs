using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Persistance.Configs
{
    class CoupanConfig : IEntityTypeConfiguration<Coupan>
    {
        public void Configure(EntityTypeBuilder<Coupan> builder)
        {
            builder.HasKey(c => c.Code);
            builder.Property(c => c.Code)
                .ValueGeneratedNever()
                .HasMaxLength(12);

            builder.Ignore(c => c.AvailableCount);

        }
    }
}
