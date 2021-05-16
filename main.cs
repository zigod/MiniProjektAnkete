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
        public string naziv_;
        public main(string naziv)
        {
            InitializeComponent();
            polnjenje();
            naziv_ = naziv;
        }

        private void polnjenje()
        {
            krajBox.Items.Clear();
            List<Kraji> kraj = baza.izpisKrajev();

            foreach (Kraji x in kraj)
            {
                string skupi = x.Ime + " | " + x.PostnaSt.ToString();

                krajBox.Items.Add(skupi);
            }

            List<Dijaki> dijaki = baza.izpisDijakov();
            foreach (Dijaki d in dijaki)
            {
                dijakiGridView.Rows.Add(new object[] { d.Id, d.Ime, d.Priimek, d.Sola, d.Datum, d.Kraj, "Več" });
            }
        }

        private void dodajDijakaButton_Click(object sender, EventArgs e)
        {
            string ime = imeBox.Text;

            string priimek = priimekBox.Text;

            string sola = solaBox.Text;

            string krajANDpostna = (string)krajBox.SelectedItem;

            string datum = datumPicker.Value.ToString("yyyy-MM-dd");

            string[] krajPosta = krajANDpostna.Split(new string[] { " | " }, StringSplitOptions.None);

            bool potrditev = baza.dodajDijaka(ime, priimek, sola, datum, krajPosta[0], krajPosta[1]);

            if(potrditev == false)
            {
                MessageBox.Show("Dodajanje ni bilo uspešno. Dijak je že v sistemu ali pa ste se zatipkali.");
            }
            else
            {
                imeBox.Clear();
                priimekBox.Clear();
                solaBox.Clear();
                krajBox.SelectedIndex = 0;
            }

        }

        private void dodajAnketoButton_Click(object sender, EventArgs e)
        {
            string naslov = naslovBox.Text;
            string URL = urlBox.Text;
            string opis = opisBox.Text;
            Ankete anketa = new Ankete(naslov, URL, opis);

            MessageBox.Show(naziv_);
            bool preveritev = baza.dodajAnketo(anketa.naslov, anketa.url, anketa.opis, naziv_);
            
            if (preveritev == false)
            {
                naslovBox.Clear();
                urlBox.Clear();
                opisBox.Clear();
                MessageBox.Show("Dodajanje ankete ni bilo uspešno. ");
            }
            else if (preveritev == true)
            {
                naslovBox.Clear();
                urlBox.Clear();
                opisBox.Clear();
                MessageBox.Show("Dodajanje ankete je bilo uspešno. ");
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            nazivLabel1.Text = "Dobrodošli " + naziv_;
            nazivLabel2.Text = "Dobrodošli " + naziv_;
            nazivLabel3.Text = "Dobrodošli " + naziv_;
        }

        private void dijakiGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(dijakiGridView.Rows[e.RowIndex].Cells[0].Value);

                podatkiodijaku pod = new podatkiodijaku(id);
                pod.ShowDialog();

            }
        }
    }
}
