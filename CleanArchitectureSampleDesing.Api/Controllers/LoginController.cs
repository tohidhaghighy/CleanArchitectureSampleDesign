using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchitectureSampleDesing.Api.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            await Task.CompletedTask;
            return Ok();
        }
    }
}
