using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LTMS.Core.CommonUtilities;
using LTMS.Core.DTO.SearchContext;
using LTMS.Core.SearchContext;
using LTMS.Domain.Model;

namespace LTMS.Api.Mapper.SearchContext
{
    public static class SearchContractCntxDtoMapper
    {
        private static IMapper _mapper;
        static SearchContractCntxDtoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SearchContractCntxDto, SearchContractCntx>()
                    .ForMember(a => a.ContractId, opt => opt.MapFrom(a => a.ContractId))
                    .ForMember(a => a.AgreementTypeId, opt => opt.MapFrom(a => a.AgreementTypeId))
                    .ForMember(a => a.CustomerId, opt => opt.MapFrom(a => a.CustomerId))
                    .ForMember(a => a.ContractType, opt => opt.MapFrom(a => a.ContractType))
                    .ForMember(a => a.AuditTypeId, opt => opt.MapFrom(a => a.AuditTypeId))
                    .ForMember(a => a.StartDate, opt => opt.MapFrom(a => a.StartDate.GetMiladiDateTime()))
                    .ForMember(a => a.EndDate, opt => opt.MapFrom(a => a.EndDate.GetMiladiDateTime()));
            });

            _mapper = config.CreateMapper();
        }
        public static SearchContractCntx ToSearchContext(SearchContractCntxDto lst)
        {
            return _mapper.Map<SearchContractCntxDto, SearchContractCntx>(lst);
        }
    }
}
