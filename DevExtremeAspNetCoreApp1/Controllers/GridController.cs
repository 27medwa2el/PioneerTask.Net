﻿using Microsoft.AspNetCore.Mvc;
namespace DevExtremeAspNetCoreApp1.Controllers
{
    public class GridController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
