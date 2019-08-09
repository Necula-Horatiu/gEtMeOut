using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gEtMeOut.Repositories.FavEvent
{
    public interface IFavEventRepository
    {
        bool AddFavEvent(int IdUser, int IdEvent);
    }
}
