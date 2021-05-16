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
        public podatkiodijaku()
        {
            InitializeComponent();
            polnjenje();
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
            RETURNS TABLE(id_a integer, naslov_ varchar, url_ varchar, opis_ varchar)
            AS $$
            DECLARE

            BEGIN
            RETURN QUERY
	        SELECT a.id, a.naslov, a.opis., a.url FROM poslane_ankete p INNER JOIN ankete a WHERE (p.dijak_id = ajdi);


                END;
                $$
                LANGUAGE 'plpgsql'*/
        }
    }
}
