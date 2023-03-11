using LTMS.Core.DTO.Request;
using LTMS.Domain.IRepositroy;
using LTMS.Domain.IService;
using LTMS.Domain.Model;

namespace LTMS.Domain.Service
{
    public class AuditTypeService : BaseCrudService<AuditType>,IAuditTypeService
    {
        private IAuditTypeRepository _auditTypeRepository;

        public AuditTypeService(IAuditTypeRepository repository ) : base(repository)
        {
            _auditTypeRepository = repository;
        }
    }
}
