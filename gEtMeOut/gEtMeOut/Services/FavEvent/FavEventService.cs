using System;
using gEtMeOut.Repositories.FavEvent;
using gEtMeOut.Models;
using System.Collections.Generic;

namespace gEtMeOut.Services.FavEvent
{
    public class FavEventService : IFavEventService
    {
        private IFavEventRepository _favEventRepository;

        public FavEventService(IFavEventRepository favEventRepository)
        {
            this._favEventRepository = favEventRepository;
        }

        public bool AddFavEvent(int IdUser, int IdEvent)
        {
            return _favEventRepository.AddFavEvent(IdUser, IdEvent);
        }

        public List<NotifyModel> NotifyUser(int IdUser)
        {
            return _favEventRepository.NotifyUser(IdUser);
        }

        public bool RemoveFavEvent(int IdFavEvent)
        {
            return _favEventRepository.RemoveFavEvent(IdFavEvent);
        }
    }
}
