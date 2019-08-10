using System.Collections.Generic;
using gEtMeOut.Models;

namespace gEtMeOut.Services.FavEvent
{
    public interface IFavEventService
    {
        bool AddFavEvent(int IdUser, int IdEvent);

        List<NotifyModel> NotifyUser(int IdUser);
    }
}
