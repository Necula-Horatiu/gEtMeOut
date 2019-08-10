using System;
using System.Collections.Generic;
using System.Linq;
using gEtMeOut.Data;
using gEtMeOut.Models;

namespace gEtMeOut.Repositories.Event
{
    public class EventRepository : IEventRepository
    {
        private DataContext db = new DataContext();

        public List<Models.EventToReturn> GetEventsByLocationAndInterests(User user, int km)
        {
            int max_km = 5;
            if (km != 0)
            {
                max_km = km;
            }
            List<Models.Event> events = db.Event.ToList();
            List<EventToReturn> my_list = new List<EventToReturn>();

            foreach (Models.Event e in events)
            {
                var query = from u in db.Locatie
                            where u.Id == e.Id_Locatie
                            select u;

                double ky = 40000 / 360;
                double kx = Math.Cos(Math.PI * user.Latitudine / 180.0) * ky;
                double dx = Math.Abs(user.Longitudine - query.First().Longitudine) * kx;
                double dy = Math.Abs(user.Latitudine - query.First().Latitudine) * ky;
                double res = Math.Sqrt(dx * dx + dy * dy);
                if (res <= max_km)
                {
                    string[] words = user.Interese.Split(',');
                    foreach(var word in words)
                    {
                        if (e.Tags.ToLower().Contains(word.ToLower()))
                        {
                            var final_event = new EventToReturn();
                            final_event.Adresa = query.FirstOrDefault().Adresa + ", " + query.FirstOrDefault().Nume;
                            final_event.Info = e.Info;
                            final_event.Nume = e.Titlu;
                            final_event.PretBilet = e.Pret.ToString() + " de lei";
                            final_event.Data = e.Data;


                            my_list.Add(final_event);
                        }
                    }
                }
            }

            return my_list;
        }

        public List<EventToReturn> GetFavoriteEvents(int id)
        {

            var query = from u in db.Event
                        join rsign in db.FavEvent on u.Id equals rsign.IdEvent
                        join rsign2 in db.User on rsign.IdUser equals id
                        select u;

            List<Models.Event> query_list = query.ToList();
            List<EventToReturn> my_list = new List<EventToReturn>();

            if (query_list.Count() > 0)
            {
                for (int i = 0; i < query_list.Count(); i++)
                {
                    var final_event = new EventToReturn();
                    var query2 = from u in db.Locatie
                                 where u.Id == query_list[i].Id_Locatie
                                 select u;

                    final_event.Adresa = query2.First().Adresa;
                    final_event.Info = query_list[i].Info;
                    final_event.Nume = query_list[i].Titlu;
                    final_event.PretBilet = query_list[i].Pret.ToString() + " de lei";
                    final_event.Data = query_list[i].Data;

                    my_list.Add(final_event);
                }
            }

            if (my_list.Count == 0)
            {
                return null;
            }
            return my_list;
                
        }
    }
}
