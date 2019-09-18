using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gEtMeOut.Models;
using gEtMeOut.Repositories;

namespace gEtMeOut.Services.Event
{
    public class EventService : IEventService
    {
        private Repositories.Event.IEventRepository _eventRepository;

        public EventService(Repositories.Event.IEventRepository eventService)
        {
            this._eventRepository = eventService;
        }

        public List<EventToReturn> GetEventsByLocationAndInterests(int idUser, int km)
        {
            return _eventRepository.GetEventsByLocationAndInterests(idUser, km);
        }

        public List<EventToReturn> GetEventsByMoney(int idUser, int km, double min, double max)
        {
            return _eventRepository.GetEventsByMoney(idUser, km, min, max);
        }

        public List<EventToReturn> GetFavoriteEvents(int id)
        {
            return _eventRepository.GetFavoriteEvents(id);
        }

        public List<EventToReturn> GetPopularEvents()
        {
           return _eventRepository.GetPopularEvents();
        }
    }
}
