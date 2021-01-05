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

        public void wtf()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connect))
            {
                con.Open();
                con.Close();
            }
        }
    }
}