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
        public int id_d;
        public anketedijaka(int id_d_)
        {
            InitializeComponent();
            polnjenje();
            id_d = id_d_;
        }

        private void polnjenje()
        {
            anketeGrid.Rows.Clear();

            List<Ankete> anketa = baza.izpisAnket();

            foreach (Ankete a in anketa)
            {
                anketeGrid.Rows.Add(new object[] { a.id, a.naslov, a.url, a.opis, "Dodaj" });
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Ankete> anketa = baza.searchAnket(searchBox.Text, id_d);

            foreach (Ankete a in anketa)
            {
                anketeGrid.Rows.Add(new object[] { a.id, a.naslov, a.url, a.opis, "Dodaj" });
            }
        }

        private void anketeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id_a = Convert.ToInt32(anketeGrid.Rows[e.RowIndex].Cells[0].Value);

                string date = DateTime.Now.ToString("yyyy-MM-dd");

                baza.dodajAnketoDijaku(id_d, id_a, date);

                polnjenje();
            }
        }


    }
}
