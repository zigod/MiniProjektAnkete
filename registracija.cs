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
    public partial class registracija : Form
    {
        public registracija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naziv = nazivBox.Text.ToString();

            string mail = mailBox.Text.ToString();

            string geslo = gesloBox.Text.ToString();

            geslo = gesla.kriptiraj(geslo);

            baza.registracija(naziv, mail, geslo);

            main main = new main(naziv);

            main.Show();

            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            prijava prijava = new prijava();

            prijava.Show();

            this.Hide();
        }
    }
}
