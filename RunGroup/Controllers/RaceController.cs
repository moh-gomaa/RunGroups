﻿using Microsoft.AspNetCore.Mvc;

namespace RunGroup.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}