using Microsoft.AspNetCore.Mvc;

namespace Movie_Tracer_sdf1.Controllers
{
    public class TopRatedController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ActivePage"] = "TopRated";
            return View();
        }
    }
}
