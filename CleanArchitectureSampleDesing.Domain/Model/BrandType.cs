using LTMS.Domain.Model;
using System;

namespace CleanArchitectureSampleDesing.Domain.Model
{
    public class BrandType : Entity<Int16>
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
