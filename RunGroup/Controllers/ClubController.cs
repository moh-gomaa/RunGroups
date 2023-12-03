﻿using Microsoft.AspNetCore.Mvc;
using RunGroup.Data;

namespace RunGroup.Controllers
{
    public class ClubController : Controller
    {
        private readonly AppDbContext _context;

        public ClubController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var clubs = _context.Clubs.ToList();

            return View(clubs);
        }
    }
}