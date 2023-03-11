using Microsoft.AspNetCore.Mvc;
using CleanArchitectureSampleDesing.Core.DTO.SearchContext;
using CleanArchitectureSampleDesing.Domain.IService;
using System.Threading.Tasks;

namespace CleanArchitectureSampleDesing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        IItemCatagoryService _itemCatagoryService;
        public ItemController(IItemCatagoryService itemCatagoryService)
        {
            _itemCatagoryService = itemCatagoryService;
        }
        public IActionResult Index()
        {
            _itemCatagoryService.GetAll();
            return null;
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetList()
        {
            await Task.CompletedTask;
            return Ok();
        }
        [HttpGet("List")]
        public async Task<IActionResult> Search(SearchItemCntxDto SearchCntx)
        {
            await Task.CompletedTask;
            return Ok();
        }
    }
}
