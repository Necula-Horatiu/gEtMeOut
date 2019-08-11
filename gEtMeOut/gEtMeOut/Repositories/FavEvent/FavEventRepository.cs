using System;
using System.Collections.Generic;
using System.Linq;
using gEtMeOut.Data;
using gEtMeOut.Repositories.Event;
using gEtMeOut.Models;

namespace gEtMeOut.Repositories.FavEvent
{
    public class FavEventRepository : IFavEventRepository
    {
        DataContext db = new DataContext();
        EventRepository eventRepository = new EventRepository();

        public bool AddFavEvent(int IdUser, int IdEvent)
        {
            if (IdUser != 0 && IdEvent != 0)
            {
                var query = from u in db.FavEvent
                            where u.IdEvent == IdEvent && u.IdUser == IdUser
                            select u;
                if (query.Count() == 0)
                {
                    db.FavEvent.Add(new Models.FavEvent(IdUser, IdEvent));
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public List<NotifyModel> NotifyUser(int IdUser)
        {
            List<EventToReturn> mylist = eventRepository.GetFavoriteEvents(IdUser);
            List<NotifyModel> notifylist = new List<NotifyModel>();

            for (int i = 0; i < mylist.Count(); i++)
            {
                double hs = mylist[i].Data.Subtract(DateTime.Now).TotalHours;
                if (hs < 1.5 && hs > 0)
                {
                    notifylist.Add(new NotifyModel(mylist[i], hs));
                } 
            }

            return notifylist;
        }
    }
}
