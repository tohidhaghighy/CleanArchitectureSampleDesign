using Framework.Persistance;
using LTMS.Domain.Service;
using CleanArchitectureSampleDesing.Domain.IService;
using CleanArchitectureSampleDesing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Domain.Service
{
    internal class OptionGroupTypeService : BaseCrudService<OptionGroupType>, IOptionGroupTypeService
    {
        public OptionGroupTypeService(IRepository<OptionGroupType> repository) : base(repository)
        {
        }
    }
}
