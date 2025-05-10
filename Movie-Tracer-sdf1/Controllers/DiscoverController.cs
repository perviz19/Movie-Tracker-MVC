using Microsoft.AspNetCore.Mvc;

namespace Movie_Tracer_sdf1.Controllers
{
    public class DiscoverController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ActivePage"] = "Discover";
            return View();
        }
    }
}
