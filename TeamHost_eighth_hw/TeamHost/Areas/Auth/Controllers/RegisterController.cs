using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace TeamHost.Web.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class RegisterController : Controller
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync([FromForm] UserRegisterDto userRegisterDto)
        {
            if (!ModelState.IsValid)
                return View();

            var userRegisterCommand = new UserRegisterCommand(userRegisterDto);
            var result = await _mediator.Send(userRegisterCommand);
            return Ok(result);
        }
    }
}
