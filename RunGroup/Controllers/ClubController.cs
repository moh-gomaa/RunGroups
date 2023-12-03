using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Detail(int id)
        {
            var obj = _context.Clubs
                .Include(x => x.Address)
                .FirstOrDefault(x => x.Id == id);

            return View(obj);
        }
    }
}