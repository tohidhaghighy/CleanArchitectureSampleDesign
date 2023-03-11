using LTMS.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Domain.Model
{
    public class ItemImage : Entity<Int32>
    {
        public int ItemId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public Item Item { get; set; }
    }
}
