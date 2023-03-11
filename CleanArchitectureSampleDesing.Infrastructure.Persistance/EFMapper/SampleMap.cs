//using LTMS.Domain.Model;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace LTMS.Infrastructure.Persistance.EFMapper
//{
//    public class SampleMap : IEntityTypeConfiguration<Sample>
//    {
//        public void Configure(EntityTypeBuilder<Sample> builder)
//        {
//            builder.ToTable("Samples");
//            builder.HasKey(key => key.Id);
//            builder.HasOne(e => e.Contract).WithMany().HasForeignKey(key => key.ContractId);
//            builder.HasOne(e => e.SampleType).WithMany().HasForeignKey(key => key.SampleTypeId);
//        }
//    }
//}
