using Microsoft.AspNetCore.Mvc;
using RunGroup.Interfaces;

namespace RunGroup.Controllers
{
    public class RaceController : Controller
    {
        private readonly IRaceRepository _raceRepository;

        public RaceController(IRaceRepository raceRepository)
        {
            _raceRepository = raceRepository;
        }

        public async Task<IActionResult> Index()
        {
            var races = await _raceRepository.GetAll();

            return View(races);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var obj = await _raceRepository.GetById(id);

            return View(obj);
        }
    }
}