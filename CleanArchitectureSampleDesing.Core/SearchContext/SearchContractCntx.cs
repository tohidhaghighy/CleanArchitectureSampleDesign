using System;
using System.Collections.Generic;
using System.Text;

namespace LTMS.Core.SearchContext
{
    public class SearchContractCntx: BasePagerCntx
    {
        public long? ContractId { get; set; }
        public long? CustomerId { get; set; }
        public int? AuditTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte? ContractType { get; set; }
        public byte? AgreementTypeId { get; set; }
    }
}
