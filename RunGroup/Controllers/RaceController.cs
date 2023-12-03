using Microsoft.AspNetCore.Mvc;
using RunGroup.Data;

namespace RunGroup.Controllers
{
    public class RaceController : Controller
    {
        private readonly AppDbContext _context;
        public RaceController(AppDbContext context)
        {
            _context = context;   
        }

        public IActionResult Index()
        {
            var races = _context.Races.ToList();

            return View(races);
        }
    }
}