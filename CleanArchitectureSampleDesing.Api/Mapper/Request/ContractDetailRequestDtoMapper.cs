//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using AutoMapper;
//using LTMS.Core.CommonUtilities;
//using LTMS.Core.DTO.Request;
//using LTMS.Domain.Model;

//namespace LTMS.Api.Mapper.Request
//{
//    public static class ContractDetailRequestDtoMapper
//    {
//        private static IMapper _mapper;
//        static ContractDetailRequestDtoMapper()
//        {
//            var config = new MapperConfiguration(cfg =>
//            {
//                cfg.CreateMap<ContractDetailRequestDto, ContractDetail>()
//                    .ForMember(a => a.ContractId, opt => opt.MapFrom(a => a.ContractId))
//                    .ForMember(a => a.SampleParameterMapPriceId, opt => opt.MapFrom(a => a.SampleParameterMapPriceId));
//            });

//            _mapper = config.CreateMapper();
//        }
//        public static List<ContractDetail> ToRequest(List<ContractDetailRequestDto> requestDto)
//        {
//            return _mapper.Map<List<ContractDetailRequestDto>,List<ContractDetail>>(requestDto);
//            //  
//        }
//        public static ContractDetail ToRequest(ContractDetailRequestDto requestDto)
//        {
//            return _mapper.Map<ContractDetailRequestDto, ContractDetail>(requestDto);
//            //  
//        }
//    }
//}
