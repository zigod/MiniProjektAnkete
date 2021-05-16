using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINIProjektUPB
{
    class Ankete
    {
        public int id { get; set; }
        public string naslov { get; set; }
        public string url { get; set; }
        public string opis { get; set; }

        public string datum { get; set; }

        public Ankete(string naslov_, string url_, string opis_)
        {
            naslov = naslov_;
            url = url_;
            opis = opis_;
        }

        public Ankete(int id_, string naslov_, string url_, string opis_)
        {
            id = id_;
            naslov = naslov_;
            url = url_;
            opis = opis_;
        }

        public Ankete(int id_, string naslov_, string url_, string opis_, string datum_)
        {
            id = id_;
            naslov = naslov_;
            url = url_;
            opis = opis_;
            datum = datum_;
        }
    }
}
