using System;
using System.Collections.Generic;
using System.Text;

namespace LTMS.Core.DTO.SearchContext
{
    public class SearchContractCntxDto : BasePagerCntxDto
    {
        public long? ContractId { get; set; }
        public long? CustomerId { get; set; }
        public int? AuditTypeId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public byte? ContractType { get; set; }
        public byte? AgreementTypeId { get; set; }
    }
}
