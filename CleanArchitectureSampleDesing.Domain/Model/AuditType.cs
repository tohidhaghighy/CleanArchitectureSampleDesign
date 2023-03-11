using System.ComponentModel.DataAnnotations.Schema;

namespace LTMS.Domain.Model
{
    public class AuditType : Entity<int>
    {
        public string Title { get; set; }
        [ForeignKey("ActivityType")]
        public int? ActivityTypeId { get; set; }
        
        public ActivityType ActivityType { get; set; }
    }
}
