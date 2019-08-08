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

        public double Longitudine { get; set; }

        public double Latitudine { get; set; }

        public string Interese { get; set; }

        public string Username { get; set; }

        public string Parola { get; set; }
    }
}