using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Areas.Profile.Controllers
{
    [Area("Profile")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
