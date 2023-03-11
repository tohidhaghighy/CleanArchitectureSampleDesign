using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanArchitectureSampleDesing.Domain.Model;

namespace CleanArchitectureSampleDesing.Infrastructure.Persistance.EFMapper
{
    public class ItemSubCatagoryMap : IEntityTypeConfiguration<ItemSubCatagory>
    {
        public void Configure(EntityTypeBuilder<ItemSubCatagory> builder)
        {
            
            builder.ToTable(typeof(ItemSubCatagory).Name);
            builder.HasKey(key => key.Id);
            builder.HasOne(e => e.ItemCatagory).WithMany().HasForeignKey(key => key.ItemCatagoryId);
        }
    }
}
