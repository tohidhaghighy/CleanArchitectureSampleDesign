//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using AutoMapper;
//using LTMS.Core.CommonUtilities;
//using LTMS.Core.DTO.Response;
//using LTMS.Domain.Model;

//namespace LTMS.Api.Mapper.Response
//{
//    public static class LegalRequirementResponseDtoMapper
//    {
//        private static IMapper _mapper;
//        static LegalRequirementResponseDtoMapper()
//        {
//            var config = new MapperConfiguration(cfg =>
//            {
//                cfg.CreateMap<LegalRequirement, LegalRequirementResponseDto>()
//                    .ForMember(a => a.Id, opt => opt.MapFrom(a => a.Id))
//                    .ForMember(a => a.ParameterTypeId, opt => opt.MapFrom(a => a.SampleParameterMap.ParameterTypeId))
//                    .ForMember(a => a.ParameterTypeTitle,
//                        opt => opt.MapFrom(a => a.SampleParameterMap.SampleType.Title))
//                    .ForMember(a => a.ParameterTypeId, opt => opt.MapFrom(a => a.SampleParameterMap.ParameterTypeId))
//                    .ForMember(a => a.ParameterTypeTitle,
//                        opt => opt.MapFrom(a => a.SampleParameterMap.ParameterType.Title));
//            });

//            _mapper = config.CreateMapper();
//        }
//        public static IEnumerable<LegalRequirementResponseDto> ToResponse(IEnumerable<LegalRequirement> lst)
//        {
//            return _mapper.Map<IEnumerable<LegalRequirement>, IEnumerable<LegalRequirementResponseDto>>(lst);
//            //  
//        }
//    }
//}
