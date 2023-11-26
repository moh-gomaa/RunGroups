using Microsoft.AspNetCore.Mvc;

namespace RunGroup.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}