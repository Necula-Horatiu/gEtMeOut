using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gEtMeOut.Models;

namespace gEtMeOut.Services.Event
{

    public interface IEventService
    {
        List<EventToReturn> GetEventsByLocationAndInterests(int idUser, int km);

        List<EventToReturn> GetFavoriteEvents(int id);

        List<EventToReturn> GetPopularEvents();

        List<EventToReturn> GetEventsByMoney(int idUser, int km, double min, double max);
    }
}
