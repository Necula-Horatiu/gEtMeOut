using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gEtMeOut.Models;

namespace gEtMeOut.Services.Event
{

    public interface IEventService
    {
        List<Models.Event> GetEventsByLocationAndInteresets(User user, int km);
    }
}
