using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gEtMeOut.Data;

namespace gEtMeOut.Repositories.FavEvent
{
    public class FavEventRepository : IFavEventRepository
    {
        DataContext db = new DataContext();

        public bool AddFavEvent(int IdUser, int IdEvent)
        {
            if (IdUser != 0 && IdEvent != 0)
            {
                db.FavEvent.Add(new Models.FavEvent(IdUser, IdEvent));
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
