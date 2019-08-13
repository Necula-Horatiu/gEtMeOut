using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gEtMeOut.Models;
using gEtMeOut.Services.FavEvent;
using Microsoft.Extensions.Logging;

namespace gEtMeOut.Controllers
{
    [Route("api/favevent")]
    public class FavEventController : Controller
    {
        private IFavEventService _favEventServices;

        private readonly ILogger _logger;
        
        public FavEventController(IFavEventService favEventService, ILogger<FavEventController> logger)
        {
            this._favEventServices = favEventService;
            this._logger = logger;
        }

        [Route("")]
        [HttpPost]
        public IActionResult AddFavEvent([FromBody] FavEvent favEvent)
        {
            if (_favEventServices.AddFavEvent(favEvent.IdUser, favEvent.IdEvent))
            {
                _logger.LogInformation(String.Format("The event with id {0} added for user {1}", favEvent.IdEvent, favEvent.IdUser));
                return Ok(1);
            }
            return Ok(0);
        }

        [Route("notify")]
        [HttpPost]
        public IActionResult NotifyUser([FromBody] FavEvent favEvent)
        {
            return Ok(_favEventServices.NotifyUser(favEvent.IdUser));
        }

        [Route("")]
        [HttpDelete]
        public IActionResult RemoveFavEvent([FromBody] FavEvent favEvent)
        {
            _logger.LogInformation(String.Format("The event with id {0} was deleted", favEvent.Id));
            return Ok(_favEventServices.RemoveFavEvent(favEvent.Id));
        }

    }
}
