using Framework.Persistance;
using LTMS.Infrastructure.Persistance;
using CleanArchitectureSampleDesing.Domain.IRepositroy;
using CleanArchitectureSampleDesing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Infrastructure.Persistance.Repository
{
    public class ItemImageRepository : EFRepositoryBase<CleanArchitectureSampleDesingDbContext, ItemImage>, IItemImageRepository
    {
        public ItemImageRepository(CleanArchitectureSampleDesingDbContext context) : base(context)
        {
        }
    }
}
