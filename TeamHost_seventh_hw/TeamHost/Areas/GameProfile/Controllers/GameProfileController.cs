using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TeamHost.WebAPI.Areas.GameProfile.Controllers
{
    [Route("[controller]")]
    public class GameProfileController : Controller
    {
        private readonly IMediator _mediator;

        public GameProfileController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{gameName}")]
        public async Task<IActionResult> Index(string gameName)
        {
            var getGameQuery = new GetGameQuery(gameName);
            var game = await _mediator.Send(getGameQuery);

            return View(game);
        }
    }
}
