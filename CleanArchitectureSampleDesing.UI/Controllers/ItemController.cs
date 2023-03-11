using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureSampleDesing.UI.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
