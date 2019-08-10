using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gEtMeOut.Models
{
    public class NotifyModel
    {
        public EventToReturn EventToReturn { get; set; }

        public double HoursLeft { get; set; }

        public NotifyModel(EventToReturn eventToReturn, double hoursLeft)
        {
            this.EventToReturn = eventToReturn;
            this.HoursLeft = hoursLeft;
        }
    }
}
