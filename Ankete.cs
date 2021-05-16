using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINIProjektUPB
{
    class Ankete
    {

        public string naslov { get; set; }

        public string url { get; set; }
        public string opis { get; set; }

        public Ankete(string naslov_, string url_, string opis_)
        {
            naslov = naslov_;
            url = url_;
            opis = opis_;
        }
    }
}
