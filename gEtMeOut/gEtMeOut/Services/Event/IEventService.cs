using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gEtMeOut.Models;

namespace gEtMeOut.Services.Event
{

    public interface IEventService
    {
        List<EventToReturn> GetEventsByLocationAndInteresets(User user, int km);

        List<EventToReturn> GetFavoriteEvents(int id);
    }
}
