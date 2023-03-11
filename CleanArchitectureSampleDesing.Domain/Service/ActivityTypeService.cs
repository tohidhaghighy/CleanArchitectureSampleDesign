using LTMS.Core.DTO.Request;
using LTMS.Domain.IRepositroy;
using LTMS.Domain.IService;
using LTMS.Domain.Model;

namespace LTMS.Domain.Service
{
    public class ActivityTypeService : BaseCrudService<ActivityType>, IActivityTypeService
    {
        private IActivityTypeRepository _activityTypeRepository;
        public ActivityTypeService(IActivityTypeRepository repository) : base(repository)
        {
            _activityTypeRepository = repository;
        }
    }
}
