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
    public partial class main : Form
    {
        public main(string naziv)
        {
            polnjenje();
            InitializeComponent();
        }

        private void polnjenje()
        {
            List<Kraji> kraj = baza.izpisKrajev();

            foreach (Kraji x in kraj)
            {
                string skupi = x.Ime + " | " + x.PostnaSt.ToString();

                krajBox.Items.Add(skupi);
            }
        }

        private void dodajDijakaButton_Click(object sender, EventArgs e)
        {
            string ime = imeBox.Text;

            string priimek = priimekBox.Text;

            string sola = solaBox.Text;

            string datum = datumPicker.Value.ToString("yyyy-MM-dd");


        }
    }
}
