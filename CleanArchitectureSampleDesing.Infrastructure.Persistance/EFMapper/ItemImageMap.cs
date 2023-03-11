using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanArchitectureSampleDesing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Infrastructure.Persistance.EFMapper
{
    public class ItemImageMap : IEntityTypeConfiguration<ItemImage>
    {
        public void Configure(EntityTypeBuilder<ItemImage> builder)
        {

            builder.ToTable(typeof(ItemImage).Name);
            builder.HasKey(key => key.Id);
            builder.HasOne(e => e.Item).WithMany().HasForeignKey(key => key.ItemId);
        }
    }
}
