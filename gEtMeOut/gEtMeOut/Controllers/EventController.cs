using Microsoft.AspNetCore.Mvc;
using gEtMeOut.Models;
using gEtMeOut.Services.Event;
using Microsoft.Extensions.Logging;

namespace gEtMeOut.Controllers
{
    [Route("api/event")]
    public class EventController : Controller
    {
        private IEventService _eventService;

        private readonly ILogger _logger;

        public EventController(IEventService eventService, ILogger<EventController> logger)
        {
            this._eventService = eventService;
            this._logger = logger;
        }

        [Route("{km?}")]
        [HttpPost]
        public IActionResult GetEventsForUser([FromBody]User data, int km)
        {
            var events = _eventService.GetEventsByLocationAndInteresets(data, km);
            if (events == null)
            {
                return Ok(0);
            }
            return Ok(events);
        }

        [Route("favorite")]
        [HttpPost]
        public IActionResult GetFavEventsForUser([FromBody] User user)
        {
            var events = _eventService.GetFavoriteEvents(user.Id);
            if (events == null)
            {
                return Ok(0);
            }
            return Ok(events);
        }

        [Route("popular")]
        [HttpPost]
        public IActionResult GetPopularEvents()
        {
            _eventService.GetPopularEvents();
            return Ok();
        }
    }
}
