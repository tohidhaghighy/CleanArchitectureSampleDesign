using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanArchitectureSampleDesing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Infrastructure.Persistance.EFMapper
{
    public class BrandTypeMap : IEntityTypeConfiguration<BrandType>
    {
        public void Configure(EntityTypeBuilder<BrandType> builder)
        {
            builder.ToTable(typeof(BrandType).Name);
            builder.HasKey(key => key.Id);
        }
    }
}
