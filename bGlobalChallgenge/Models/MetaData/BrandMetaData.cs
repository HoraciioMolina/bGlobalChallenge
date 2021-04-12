using bGlobalChallgenge.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bGlobalChallgenge.Models.MetaData
{
    public class BrandMetaData : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(SeedBrands());
        }

        public List<Brand> SeedBrands()
        {
            var brands = new List<Brand>
            {
                new Brand{
                    Id= 1,
                    Name = "Fiat"
                },
                new Brand{
                    Id= 2,
                    Name = "Peugeot"
                },
                new Brand{
                    Id= 3,
                    Name = "Audi"
                },
            };

            return brands;
        }
    }
}
