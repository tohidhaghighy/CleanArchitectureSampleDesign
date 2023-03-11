using LTMS.Core.DTO.SearchContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Core.DTO.SearchContext
{
    public class SearchItemCatagoryCntxDto : BasePagerCntxDto
    {
        public string Title { get; set; }
        public string Code { get; set; }
    }
}
