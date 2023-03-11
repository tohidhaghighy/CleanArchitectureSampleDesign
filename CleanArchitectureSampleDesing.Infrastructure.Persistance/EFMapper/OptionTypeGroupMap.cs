using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanArchitectureSampleDesing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Infrastructure.Persistance.EFMapper
{
    public class OptionTypeGroupMap : IEntityTypeConfiguration<OptionGroupType>
    {
        public void Configure(EntityTypeBuilder<OptionGroupType> builder)
        {
            builder.ToTable(typeof(OptionGroupType).Name);
            builder.HasKey(key => key.Id);
        }
    }
}
