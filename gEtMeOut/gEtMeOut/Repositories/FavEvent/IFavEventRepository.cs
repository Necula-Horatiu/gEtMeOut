using System.Collections.Generic;
using gEtMeOut.Models;

namespace gEtMeOut.Repositories.FavEvent
{
    public interface IFavEventRepository
    {
        bool AddFavEvent(int IdUser, int IdEvent);

        List<NotifyModel> NotifyUser(int IdUser);

        bool RemoveFavEvent(int IdFavEvent);
    }
}
