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
using Ankete;

namespace MiniProjektAnkete
{
    public partial class Form1 : Form
    {
        private MetodeBaza db;


        public Form1()
        {
            InitializeComponent();

            db = new MetodeBaza();
        }

        string connect = BazaConn.connect();

        public void openConn()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connect))
            {
                con.Open();
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Kraji> krajiList = db.izpisKrajev();


            krajiListBox.Items.Clear();

            foreach (Kraji kraj in krajiList)
            {
               krajiListBox.Items.Add(kraj.ime + " | " + kraj.postnaSt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naziv = nazivBox.Text.ToString();

            string mail = mailBox.Text.ToString();

            string geslo = gesloBox.Text.ToString();

            db.registracija(naziv, mail, geslo);
        }
    }
}