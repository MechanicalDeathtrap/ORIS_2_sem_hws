using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Areas.Chats.Controllers
{
    [Area("Chats")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
