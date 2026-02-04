using Microsoft.AspNetCore.Mvc;
using SampleGit.Models;

namespace YourProject.Controllers
{
    public class AuthController : Controller
    {
       
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

           
            if (model.Email == "admin@test.com" && model.Password == "123456")
            {
                return RedirectToAction("Index", "Dashboard");
            }

            ViewBag.Error = "Invalid email or password";
            return View(model);
        }
    }
}
