using Microsoft.AspNetCore.Mvc;
using RunGroup.Interfaces;

namespace RunGroup.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubRepository _clubRepository;

        public ClubController(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }

        public async Task<IActionResult> Index()
        {
            var clubs = await _clubRepository.GetAll();

            return View(clubs);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var obj = await _clubRepository.GetById(id);

            return View(obj);
        }
    }
}