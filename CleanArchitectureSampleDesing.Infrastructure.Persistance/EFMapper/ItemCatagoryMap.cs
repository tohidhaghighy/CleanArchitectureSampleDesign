using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanArchitectureSampleDesing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Infrastructure.Persistance.EFMapper
{
    public class ItemCatagoryMap : IEntityTypeConfiguration<ItemCatagory>
    {
        public void Configure(EntityTypeBuilder<ItemCatagory> builder)
        {
            
            builder.ToTable(typeof(ItemCatagory).Name);
            builder.HasKey(key => key.Id);

        }
    }
}
