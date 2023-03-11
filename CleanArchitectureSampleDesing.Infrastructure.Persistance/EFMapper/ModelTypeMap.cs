using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanArchitectureSampleDesing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Infrastructure.Persistance.EFMapper
{
    public class ModelTypeMap : IEntityTypeConfiguration<ModelType>
    {
        public void Configure(EntityTypeBuilder<ModelType> builder)
        {
            
            builder.ToTable(typeof(ModelType).Name);
            builder.HasKey(key => key.Id);
            builder.HasOne(e => e.BrandType).WithMany().HasForeignKey(key => key.BrandTypeId);
        }
    }
}
