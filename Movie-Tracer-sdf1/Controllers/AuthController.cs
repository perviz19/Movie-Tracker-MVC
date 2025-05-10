using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace Movie_Tracer_sdf1.Controllers
{
    [Route("")]
    public class AuthController : Controller
    {
        [HttpGet("Login")]
        public IActionResult Login()
        {
            ViewData["ActivePage"] = "Login";
            return View();
        }

        [HttpGet("Register")]
        public IActionResult Register()
        {
            ViewData["ActivePage"] = "Register";
            return View();
        }


        [HttpPost("Login")]
        public IActionResult Login(string username, string password)
        {
            if (username == "perviz" && password == "12345")
            {
                TempData["Message"] = "Login successful";
                return RedirectToAction("Index", "Dashboard");
            }

            TempData["Error"] = "Invalid login";
            return RedirectToAction("Login");
        }


        [HttpPost("Register")]
        public IActionResult Register(string username, string password)
        {
            TempData["Message"] = $"Registered as {username}";
            return RedirectToAction("Register");
        }
    }
}
