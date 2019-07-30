using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gEtMeOut.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Titlu { get; set; }

        public double Pret { get; set; }

        public string Info { get; set; }

        public double Longitudine { get; set; }
        
        public double Latitudine { get; set; }

        public string Tags { get; set; }
    }
}
