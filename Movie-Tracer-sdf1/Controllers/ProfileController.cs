using Microsoft.AspNetCore.Mvc;

namespace Movie_Tracer_sdf1.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ActivePage"] = "Profile";
            return View();
        }
    }
}
