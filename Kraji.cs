using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINIProjektUPB
{
    class Kraji
    {
        public string Ime { get; set; }
        public string PostnaSt { get; set; }

        public Kraji(string ime, string postnaSt)
        {
            Ime = ime;
            PostnaSt = postnaSt;
        }
    }
}
