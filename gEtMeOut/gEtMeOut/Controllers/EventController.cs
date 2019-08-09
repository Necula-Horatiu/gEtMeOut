using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gEtMeOut.Models;
using gEtMeOut.Services.Event;

namespace gEtMeOut.Controllers
{
    [Route("api/event")]
    public class EventController : Controller
    {
        private IEventService _eventService;

        public EventController(IEventService eventService)
        {
            this._eventService = eventService;
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
    }
}
