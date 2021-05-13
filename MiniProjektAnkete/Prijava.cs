using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ankete;

namespace MiniProjektAnkete
{
    public partial class Prijava : Form
    {

        public Prijava()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gmail = gmailTextBox.Text;

            string geslo = gesloTextBox.Text;


            bool prijavljen = baza.prijava(gmail, geslo);

            string naziv = baza.prijavaNaziv(gmail, geslo);

            if(prijavljen == false)
            {
                MessageBox.Show("Napačni Gmail ali Geslo");

                gesloTextBox.Clear();

                gmailTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Uspešna prijava!");

                Main main = new Main(naziv);

                main.Show();

                this.Hide();
            }


        }

        private void Prijava_Load(object sender, EventArgs e)
        {

        }
    }
}
