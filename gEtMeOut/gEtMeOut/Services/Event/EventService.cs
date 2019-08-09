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

        public List<EventToReturn> GetEventsByLocationAndInteresets(User user, int km)
        {
            return _eventRepository.GetEventsByLocationAndInterests(user, km);
        }

        public List<EventToReturn> GetFavoriteEvents(int id)
        {
            return _eventRepository.GetFavoriteEvents(id);
        }
    }
}
