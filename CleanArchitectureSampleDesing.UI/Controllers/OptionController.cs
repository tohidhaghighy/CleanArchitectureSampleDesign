using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureSampleDesing.UI.Controllers
{
    public class OptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
