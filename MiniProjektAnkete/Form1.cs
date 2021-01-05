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

namespace MiniProjektAnkete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            using (NpgsqlConnection con = new NpgsqlConnection(connect))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM izpisKrajev()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                            krajiListBox.Items.Add(reader.GetString(0) + " " + reader.GetInt32(1));

                }
                con.Close();
            }
        }
    }
}