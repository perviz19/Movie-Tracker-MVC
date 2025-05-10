using Microsoft.AspNetCore.Mvc;

namespace Movie_Tracer_sdf1.Controllers
{
    public class WatchlistController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ActivePage"] = "Watchlist";
            return View();
        }
    }
}
