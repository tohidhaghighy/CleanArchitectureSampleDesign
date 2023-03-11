using LTMS.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Domain.Model
{
    public class ModelType : Entity<Int16>
    {
        public string Title { get; set; }
        public Int16 BrandTypeId { get; set; }
        public bool IsActive { get; set; }
        public BrandType BrandType { get; set; }
    }
}
