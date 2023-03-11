using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureSampleDesing.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
