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

        public List<Models.Event> GetEventsByLocationAndInterests(User user, int km)
        {
            int max_km = 10;
            if (km != 0)
            {
                max_km = km;
            }
            List<Models.Event> events = db.Event.ToList();
            List<Models.Event> my_list = new List<Models.Event>();

            foreach (Models.Event e in events)
            {
                double ky = 40000 / 360;
                double kx = Math.Cos(Math.PI * user.Latitudine / 180.0) * ky;
                double dx = Math.Abs(user.Longitudine - e.Longitudine) * kx;
                double dy = Math.Abs(user.Latitudine - e.Latitudine) * ky;
                if (Math.Sqrt(dx * dx + dy * dy) <= max_km)
                {
                    my_list.Add(e);
                }
            }

            return my_list;
        }
    }
}
