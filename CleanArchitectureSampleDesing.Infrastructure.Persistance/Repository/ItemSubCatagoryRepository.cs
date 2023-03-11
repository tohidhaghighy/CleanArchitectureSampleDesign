using Framework.Persistance;
using LTMS.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using CleanArchitectureSampleDesing.Domain.IRepositroy;
using CleanArchitectureSampleDesing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Infrastructure.Persistance.Repository
{
    public class ItemSubCatagoryRepository : EFRepositoryBase<CleanArchitectureSampleDesingDbContext, ItemSubCatagory>, IItemSubCatagoryRepository
    {
        public ItemSubCatagoryRepository(CleanArchitectureSampleDesingDbContext context) : base(context)
        {
        }
    }
}
