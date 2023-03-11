using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureSampleDesing.UI.Controllers
{
    public class ModelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
