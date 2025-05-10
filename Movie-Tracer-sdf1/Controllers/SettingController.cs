using Microsoft.AspNetCore.Mvc;

namespace Movie_Tracer_sdf1.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ActivePage"] = "Setting";
            return View();
        }
    }
}
