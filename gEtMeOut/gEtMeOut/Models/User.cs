using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gEtMeOut.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Nume { get; set; }

        public int Varsta { get; set; }

        public string Longitudine { get; set; }

        public string Latitudine { get; set; }

        public string Interese { get; set; }
    }
}