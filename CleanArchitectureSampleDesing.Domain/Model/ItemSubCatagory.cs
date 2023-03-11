using LTMS.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Domain.Model
{
    public class ItemSubCatagory : Entity<Int16>
    {
        public string Title { get; set; }
        public Int16 ItemCatagoryId { get; set; }
        public bool IsActive { get; set; }
        public ItemCatagory ItemCatagory { get; set; }
    }
}

