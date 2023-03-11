using LTMS.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Domain.Model
{
    public class ItemUnitType : Entity<Int16>
    {
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}
