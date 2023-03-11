using LTMS.Domain.IService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LTMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityTypeService _activityTypeService;
        private readonly IAuditTypeService _auditTypeService;
        public ActivityController(IActivityTypeService activityTypeService, IAuditTypeService auditTypeService)
        {
            _activityTypeService = activityTypeService;
            _auditTypeService = auditTypeService;
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetList()
        {
            var result = _activityTypeService.GetAll();
            await Task.CompletedTask;
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = _activityTypeService.FindById(id);
            await Task.CompletedTask;
            return Ok(result);
        }

        [HttpGet("{id}/audit/list")]
        public async Task<IActionResult> GetList(int id)
        {
            var result = _auditTypeService.FindBy(exp => exp.ActivityTypeId == id);
            await Task.CompletedTask;
            return Ok(result);
        }

        [HttpGet("{id}/audit/{auditId}")]
        public async Task<IActionResult> Get(int id,int auditId)
        {
            var result = _auditTypeService.FindById(auditId);
            if (result.Result.ActivityTypeId == id)
                result = null;
            await Task.CompletedTask;
            return Ok(result);
        }

        [Route("api/audit/{id}")]
        public async Task<IActionResult> GetAudit(int id)
        {
            var result = _auditTypeService.FindById(id);
            await Task.CompletedTask;
            return Ok(result);
        }
    }
}