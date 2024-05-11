using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace TeamHost.Areas.Profile.Controllers
{
    [Area("Profile")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var getUserInfoQuery = new GetUserInfoQuery();
            var userInfo = await _mediator.Send(getUserInfoQuery);
            return View(userInfo);
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm] UpdateUserInfoRequest updateUserInfoRequest)
        {
            var command = new PatchUserInfoCommand(updateUserInfoRequest);
            var response = await _mediator.Send(command);

            return View(response);
        }
    }
}
