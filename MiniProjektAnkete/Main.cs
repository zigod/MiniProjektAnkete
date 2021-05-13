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
    public partial class Main : Form
    {
        string naziv;
        private MetodeBaza db;
        public Main(string naziv_)
        {
            InitializeComponent();

            naziv = naziv_;

            db = new MetodeBaza();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
