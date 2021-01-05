using System;
using System.Collections.Generic;
using System.Text;

namespace Ankete
{
    class Metode
    {



    }

    public class Kraji
    {
        public string ime { get; set; }
        public int postnaSt { get; set; }
        public Kraji(string name, int postNum)
        {
            this.ime = name;
            this.postnaSt = postNum;
        }
    }
}
