using Microsoft.AspNetCore.Mvc;

namespace SampleGit.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
