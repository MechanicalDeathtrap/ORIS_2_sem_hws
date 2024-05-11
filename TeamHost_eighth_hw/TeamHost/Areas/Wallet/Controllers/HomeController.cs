using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Areas.Wallet.Controllers
{
    [Area("Wallet")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
