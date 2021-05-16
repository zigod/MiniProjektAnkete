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
    public partial class podatkiodijaku : Form
    {
        public podatkiodijaku(int id_, string ime_, string priimek_, string sola_, string datum_, string kraj_)
        {
            InitializeComponent();
            id_d = id_;
            ime = ime_;
            priimek = priimek_;
            sola = sola_;
            DDatum = datum_;
            Kraj = kraj_;
            polnjenje();

        }

        public int id_d;
        public string ime;
        public string priimek;
        public string sola;
        public string DDatum;
        public string Kraj;

        public string postna;

        private void polnjenje()
        {
            anketeDijakGrid.Rows.Clear();
            krajBox.Items.Clear();
            List<Kraji> kraj = baza.izpisKrajev();

            foreach (Kraji x in kraj)
            {
                string skupi = x.Ime + " | " + x.PostnaSt.ToString();

                krajBox.Items.Add(skupi);
            }
            List<Ankete> anketa = baza.izpisAnketDijak(id_d);
            //                dijakiGridView.Rows.Add(new object[] { d.Id, d.Ime, d.Priimek, d.Sola, d.Datum, d.Kraj, "Več" });
            foreach (Ankete a in anketa)
            {
                anketeDijakGrid.Rows.Add(new object[] { a.id, a.naslov, a.url, a.opis, a.datum, "Izbriši" });
            }

            imeBox.Text = ime;
            priimekBox.Text = priimek;
            solaBox.Text = sola;
            datePicker.Value = DateTime.Parse(DDatum);
            postna = baza.SelectPostno(Kraj);
            string skupno = Kraj + " | " + postna;
            krajBox.SelectedItem = skupno;
        }

        private void urediButton_Click(object sender, EventArgs e)
        {
            imeBox.Enabled = true;
            priimekBox.Enabled = true;
            solaBox.Enabled = true;
            krajBox.Enabled = true;
            datePicker.Enabled = true;
            urediButton.Enabled = false;
            potrdiButton.Enabled = true;

            /*CREATE OR REPLACE FUNCTION izpisAnketDijak(ajdi integer)
            RETURNS TABLE(id_a integer, naslov_ varchar, url_ varchar, opis_ varchar, datum_ timestamp)
            AS $$
            DECLARE

            BEGIN
            RETURN QUERY
	        SELECT a.id, a.naslov, a.url, a.opis, p.datum FROM poslane_ankete p INNER JOIN ankete a ON p.anketa_id=a.id WHERE (p.dijak_id = ajdi);
	
	        END;
            $$
            LANGUAGE 'plpgsql'*/
        }

        private void dodajAnketeDijaku_Click(object sender, EventArgs e)
        {
            anketedijaka ank = new anketedijaka(id_d);
            ank.ShowDialog();
        }

        private void anketeDijakGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int id_a = Convert.ToInt32(anketeDijakGrid.Rows[e.RowIndex].Cells[0].Value);


                baza.izbrisiAnketo(id_a);

                polnjenje();
            }
        }

        private void potrdiButton_Click(object sender, EventArgs e)
        {
            urediButton.Enabled = true;
            potrdiButton.Enabled = false;

            ime = imeBox.Text;
            priimek = priimekBox.Text;
            sola = solaBox.Text;
            DDatum = datePicker.Value.ToString("yyyy-MM-dd");
            string krajValue = (string)krajBox.SelectedItem;
            string[] krajPosta = krajValue.Split(new string[] { " | " }, StringSplitOptions.None);

            //MessageBox.Show(id_d + " " + ime + " " + priimek + " " + sola + " " + krajPosta[0] + " " + krajPosta[1] + " " + DDatum);
            baza.urediDijaka(id_d, ime, priimek, sola, krajPosta[0], krajPosta[1], DDatum);

            imeBox.Enabled = false;
            priimekBox.Enabled = false;
            solaBox.Enabled = false;
            krajBox.Enabled = false;
            datePicker.Enabled = false;

        }   
    }
}
