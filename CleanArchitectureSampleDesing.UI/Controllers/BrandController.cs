﻿using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureSampleDesing.UI.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
