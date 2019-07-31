using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gEtMeOut.Models
{
    public class Location
    {
        public int Id { get; set; }

        public string Nume { get; set; }

        public double Latitudine { get; set; }

        public double Longitudine { get; set; }

        public string Adresa { get; set; }
    }
}
