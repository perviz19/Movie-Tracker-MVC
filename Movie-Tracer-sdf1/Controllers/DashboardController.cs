    using Microsoft.AspNetCore.Mvc;

namespace Movie_Tracer_sdf1.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ActivePage"] = "Home";
            return View();
        }
    }
}
