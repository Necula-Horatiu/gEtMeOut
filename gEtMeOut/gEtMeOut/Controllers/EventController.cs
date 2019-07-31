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
        public IActionResult GetEventsForUse([FromBody]User data, int km)
        {
            var events = _eventService.GetEventsByLocationAndInteresets(data, km);
            if (events.Count == 0)
            {
                return Ok(0);
            }
            return Ok(events);
        }
    }
}
