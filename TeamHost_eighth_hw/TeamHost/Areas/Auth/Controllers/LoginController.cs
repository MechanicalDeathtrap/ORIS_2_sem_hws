using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Web.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class LoginController : Controller
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> LoginAsync([FromForm] UserLoginDto userLoginDto)
        {
            Console.WriteLine(userLoginDto.Email);
            if (!ModelState.IsValid)
                return View();

            var userLoginCommand = new UserLoginCommand(userLoginDto);
            var result = await _mediator.Send(userLoginCommand);

            if (result)
                return RedirectToAction("Index", "Home");

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            var userLogoutCommand = new UserLogoutCommand();
            await _mediator.Send(userLogoutCommand);
            return RedirectToAction("Index", "Home");
        }
    }
}
