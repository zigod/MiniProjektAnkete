using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjek
{
    class Kraji
    {
        public string Ime { get; set; }
        public int PostnaSt { get; set; }

        public Kraji(string ime, int postnaSt)
        {
            Ime = ime;
            PostnaSt = postnaSt;
        }
    }
}
