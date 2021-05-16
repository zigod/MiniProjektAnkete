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
    public partial class prijava : Form
    {
        public prijava()
        {
            InitializeComponent();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            string gmail = gmailTextBox.Text;

            string geslo = gesloTextBox.Text;

            //geslo = gesla.dekriptiraj(geslo);

            bool prijavljen = baza.prijava(gmail, geslo);

            string naziv = baza.prijavaNaziv(gmail, geslo);

            if (prijavljen == false)
            {
                MessageBox.Show("Napačni Gmail ali Geslo");

                gesloTextBox.Clear();

                gmailTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Uspešna prijava!");

                main main = new main(naziv);

                main.Show();

                this.Hide();
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registracija register = new registracija();

            register.Show();

            this.Hide();
        }
    }
}
