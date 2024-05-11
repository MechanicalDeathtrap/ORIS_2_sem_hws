using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Areas.Friends.Controllers
{
    [Area("Friends")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
