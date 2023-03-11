using LTMS.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureSampleDesing.Domain.Model
{
    public class Item : Entity<int>
    {
        public string Title { get; set; }
        public string StandardCode { get; set; }
        public string InternalCode { get; set; }
        public string Description { get; set; }
        public Int16 ModelTypeId { get; set; }
        public Int16 ItemSubCatagoryId { get; set; }
        public Int16 ItemUnitTypeId { get; set; }
        public ModelType ModelType { get; set; }
        public ItemSubCatagory ItemSubCatagory { get; set; }
        public ItemUnitType ItemUnitType { get; set; }
    }
}
