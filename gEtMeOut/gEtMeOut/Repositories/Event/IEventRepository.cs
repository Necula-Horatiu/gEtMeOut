using System.Collections.Generic;
using gEtMeOut.Models;

namespace gEtMeOut.Repositories.Event
{
    public interface IEventRepository
    { 
        List<EventToReturn> GetEventsByLocationAndInterests(int idUser, int km);

        List<EventToReturn> GetFavoriteEvents(int id);

        List<EventToReturn> GetPopularEvents();

        List<EventToReturn> GetEventsByMoney(int idUser, int km, double min, double max);
    }
}
