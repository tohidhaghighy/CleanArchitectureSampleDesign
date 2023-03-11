using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanArchitectureSampleDesing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Infrastructure.Persistance.EFMapper
{
    public class ItemOptionMap : IEntityTypeConfiguration<ItemOption>
    {
        public void Configure(EntityTypeBuilder<ItemOption> builder)
        {

            builder.ToTable(typeof(ItemOption).Name);
            builder.HasKey(key => key.Id);
            builder.HasOne(e => e.Item).WithMany().HasForeignKey(key => key.ItemId);
            builder.HasOne(e => e.OptionGroupType).WithMany().HasForeignKey(key => key.OptionGroupTypeId);
            builder.HasOne(e => e.OptionType).WithMany().HasForeignKey(key => key.OptionTypeId);
        }
    }
}
