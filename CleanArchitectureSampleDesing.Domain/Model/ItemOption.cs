using LTMS.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CleanArchitectureSampleDesing.Domain.Model
{
    public class ItemOption : Entity<Int16>
    {
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        [ForeignKey("OptionType")]
        public int OptionTypeId { get; set; }
        [ForeignKey("OptionGroupType")]
        public int OptionGroupTypeId { get; set; }
        public string OptionValue { get; set; }
        
        public Item Item { get; set; }
        public OptionType OptionType { get; set; }
        public OptionGroupType OptionGroupType { get; set; }
    }
}
