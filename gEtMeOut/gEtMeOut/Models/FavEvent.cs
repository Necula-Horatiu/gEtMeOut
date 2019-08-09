using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gEtMeOut.Models
{
    public class FavEvent
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        public int IdEvent { get; set; }

        public FavEvent(int IdUser, int IdEvent)
        {
            this.IdUser = IdUser;
            this.IdEvent = IdEvent;
        }
    }
}
