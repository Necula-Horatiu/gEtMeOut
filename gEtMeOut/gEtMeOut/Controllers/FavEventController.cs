using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gEtMeOut.Models;
using gEtMeOut.Services.FavEvent;

namespace gEtMeOut.Controllers
{
    [Route("api/favevent")]
    public class FavEventController : Controller
    {
        private IFavEventService _favEventServices;
        
        public FavEventController(IFavEventService favEventService)
        {
            this._favEventServices = favEventService;
        }

        [Route("")]
        [HttpPost]
        public IActionResult AddFavEvent([FromBody] FavEvent favEvent)
        {
            if (_favEventServices.AddFavEvent(favEvent.IdUser, favEvent.IdEvent))
            {
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
            return Ok(_favEventServices.RemoveFavEvent(favEvent.Id));
        }

    }
}
