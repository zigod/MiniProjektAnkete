using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINIProjektUPB
{
    public partial class anketedijaka : Form
    {
        public anketedijaka()
        {
            InitializeComponent();
            polnjenje();
        }

        private void polnjenje()
        {
            List<Ankete> anketa = baza.izpisAnket();

            foreach (Ankete a in anketa)
            {
                anketeGrid.Rows.Add(new object[] { a.id, a.naslov, a.url, a.opis, "Dodaj" });
            }
        }



    }
}
