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
        public int id_d;
        public podatkiodijaku(int id_)
        {
            InitializeComponent();
            polnjenje();
            id_d = id_;
        }

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

        }

        private void urediButton_Click(object sender, EventArgs e)
        {
            imeBox.Enabled = true;
            priimekBox.Enabled = true;
            solaBox.Enabled = true;
            krajBox.Enabled = true;
            datePicker.Enabled = true;
            urediButton.Enabled = false;

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
    }
}
