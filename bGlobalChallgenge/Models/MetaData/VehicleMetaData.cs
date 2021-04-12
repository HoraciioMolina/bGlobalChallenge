using bGlobalChallgenge.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bGlobalChallgenge.Models.MetaData
{
    public class VehicleMetaData : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.Property(x => x.BrandId)
                .IsRequired();

            builder.Property(x => x.Doors)
                .IsRequired();

            builder.Property(x => x.Model)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.TitularFirstName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.TitularLastName)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
