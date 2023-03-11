using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanArchitectureSampleDesing.Domain.Model;

namespace CleanArchitectureSampleDesing.Infrastructure.Persistance.EFMapper
{
    public class ItemUnitTypeMap : IEntityTypeConfiguration<ItemUnitType>
    {
        public void Configure(EntityTypeBuilder<ItemUnitType> builder)
        {
            builder.ToTable(typeof(ItemUnitType).Name);
            builder.HasKey(key => key.Id);
        }
    }
}
