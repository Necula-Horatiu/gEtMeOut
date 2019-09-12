using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gEtMeOut.Models;

namespace gEtMeOut.Repositories.Event
{
    public interface IEventRepository
    { 
        List<EventToReturn> GetEventsByLocationAndInterests(User user, int km);

        List<EventToReturn> GetFavoriteEvents(int id);

        List<EventToReturn> GetPopularEvents();
    }
}
