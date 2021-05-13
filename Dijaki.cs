using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINIProjektUPB
{
    class Dijaki
    {
        private int Id { get; set; }
        private string Ime { get; set; }
        private string Priimek { get; set; }
        private string Sola { get; set; }
        private DateTime Datum { get; set; }
        private string Kraj { get; set; }

        public Dijaki(int id, string ime, string priimek, string sola, DateTime datum, string kraj)
        {
            Id = id;
            Ime = ime;
            Priimek = priimek;
            Sola = Sola;
            Datum = datum;
            Kraj = kraj;
        }

    }
}
