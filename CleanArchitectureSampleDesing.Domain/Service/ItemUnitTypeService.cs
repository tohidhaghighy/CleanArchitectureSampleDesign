using Framework.Persistance;
using LTMS.Domain.Service;
using CleanArchitectureSampleDesing.Domain.IService;
using CleanArchitectureSampleDesing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Domain.Service
{
    public class ItemUnitTypeService : BaseCrudService<ItemUnitType>, IItemUnitTypeService
    {
        public ItemUnitTypeService(IRepository<ItemUnitType> repository) : base(repository)
        {
        }
    }
}
