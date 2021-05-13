using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINIProjektUPB
{
    class Dijaki
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Sola { get; set; }
        public string Datum { get; set; }
        public string Kraj { get; set; }

        public Dijaki(int id, string ime, string priimek, string sola, string datum, string kraj)
        {
            Id = id;
            Ime = ime;
            Priimek = priimek;
            Sola = sola;
            Datum = datum;
            Kraj = kraj;
        }

    }
}
