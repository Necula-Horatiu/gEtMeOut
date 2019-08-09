using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gEtMeOut.Services.FavEvent
{
    public interface IFavEventService
    {
        bool AddFavEvent(int IdUser, int IdEvent);
    }
}
