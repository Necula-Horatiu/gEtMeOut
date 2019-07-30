using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gEtMeOut.Models;

namespace gEtMeOut.Repositories.Event
{
    public interface IEventRepository
    { 
        List<Models.Event> GetEventsByLocationAndInterests(User user);
    }
}
