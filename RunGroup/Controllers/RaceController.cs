using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Detail(int id)
        {
            var obj = _context.Races
                .Include(x => x.Address)
                .FirstOrDefault(x => x.Id == id);

            return View(obj);
        }
    }
}