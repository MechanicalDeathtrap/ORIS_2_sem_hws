using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Areas.Favourites.Controllers
{
    [Area("Favourites")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
