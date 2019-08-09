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
        public IActionResult addFavEvent([FromBody] FavEvent favEvent)
        {
            if (_favEventServices.AddFavEvent(favEvent.IdUser, favEvent.IdEvent))
            {
                return Ok(1);
            }
            return Ok(0);
        }
    }
}
