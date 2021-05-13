using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using MiniProjektAnkete;
using MiniProjek;

namespace MiniProjektAnkete
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        public void openConn()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Kraji> krajiListt = Baza.izpisKrajev();

            krajiListBox.Items.Clear();

            foreach (Kraji kraj in krajiListt)
            {
               krajiListBox.Items.Add(kraj.ime + " | " + kraj.postnaSt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naziv = nazivBox.Text.ToString();

            string mail = mailBox.Text.ToString();

            string geslo = gesloBox.Text.ToString();

            Baza.registracija(naziv, mail, geslo);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Prijava prijava = new Prijava();

            prijava.Show();

            this.Hide();
        }
    }
}