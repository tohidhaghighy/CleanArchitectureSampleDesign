using LTMS.Core.DTO.SearchContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Core.DTO.SearchContext
{
    public class SearchItemCntxDto : BasePagerCntxDto
    {
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string SubTitle { get; set; }
        public string SubCode { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
    }
}
