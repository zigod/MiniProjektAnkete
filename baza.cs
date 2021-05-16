using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;

namespace MINIProjektUPB
{
    class baza
    {
        public static string connect()
        {
            var uriString = ConfigurationManager.AppSettings["ELEPHANTSQL_URL"] ?? "postgres://lvxpjcln:RuFqB8afYfKrAbc2VYjP--8nwtZ4NnaA@kandula.db.elephantsql.com:5432/lvxpjcln";
            var uri = new Uri(uriString);
            var db = uri.AbsolutePath.Trim('/');
            var user = uri.UserInfo.Split(':')[0];
            var passwd = uri.UserInfo.Split(':')[1];
            var port = uri.Port > 0 ? uri.Port : 5432;
            var connStr = string.Format("Server={0};Database={1};User Id={2};Password={3};Port={4}",
                uri.Host, db, user, passwd, port);
            return connStr;
        }

        public static List<Kraji> izpisKrajev()
        {
            List<Kraji> krajiList = new List<Kraji>();
            using (NpgsqlConnection con = new NpgsqlConnection(connect()))
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM izpisKrajev();", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string imeKraja = reader.GetString(0);
                    string postnaSt = reader.GetString(1);

                    Kraji reading = new Kraji(imeKraja, postnaSt);

                    krajiList.Add(reading);
                }
                con.Close();
                return krajiList;
            }
        }

        public static void registracija(string email, string geslo, string naziv)
        {


            using (NpgsqlConnection con = new NpgsqlConnection(connect()))
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT registracija('" + email + "', '" + geslo + "', '" + naziv + "');", con);

                com.ExecuteNonQuery();

                com.Dispose();

                con.Close();
            }
        }

        public static bool prijava(string email, string geslo)
        {
            bool prijavljen = false;
            using (NpgsqlConnection con = new NpgsqlConnection(connect()))
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT prijava('" + email + "', '" + geslo + "');", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    prijavljen = reader.GetBoolean(0);
                }

                com.Dispose();

                con.Close();

                return prijavljen;
            }
        }

        public static string prijavaNaziv(string email, string geslo)
        {
            string naziv = "";
            using (NpgsqlConnection con = new NpgsqlConnection(connect()))
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT prijavaNaziv('" + email + "', '" + geslo + "');", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    naziv = reader.GetString(0);
                }



                com.Dispose();

                con.Close();

                return naziv;
            }
        }

        public static bool dodajDijaka(string ime, string priimek, string sola, string datum, string kraj, string postna_st)
        {
            bool potrditev = false;
            using (NpgsqlConnection con = new NpgsqlConnection(connect()))
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT vnesiDijaka('" + ime + "', '" + priimek + "', '" + sola + "', '" + datum + "', '" + kraj + "', '" + postna_st + "');", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    potrditev = reader.GetBoolean(0);
                }



                com.Dispose();

                con.Close();

                return potrditev;
            }
        }

        public static List<Dijaki> izpisDijakov()
        {
            List<Dijaki> dijakiList = new List<Dijaki>();
            using (NpgsqlConnection con = new NpgsqlConnection(connect()))
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM izpisDijakov();", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string ime = reader.GetString(1);
                    string priimek = reader.GetString(2);
                    string sola = reader.GetString(3);
                    string datum = reader.GetTimeStamp(4).ToString();
                    string kraj = reader.GetString(5);

                    string[] dat = datum.Split(' ');


                    Dijaki reading = new Dijaki(id, ime, priimek, sola, dat[0], kraj);

                    dijakiList.Add(reading);
                }
                con.Close();
                return dijakiList;
            }
        }

        public static bool dodajAnketo(string naslov, string url, string opis, string naziv)
        {
            bool potrditev = false;
            using (NpgsqlConnection con = new NpgsqlConnection(connect()))
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT dodajAnketo('" + naslov + "', '" + url + "', '" + opis + "', '" + naziv + "');", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    potrditev = reader.GetBoolean(0);
                }



                com.Dispose();

                con.Close();

                return potrditev;
            }
        }

        public static List<Ankete> izpisAnketDijak(int id_)
        {
            List<Ankete> anketeList = new List<Ankete>();
            using (NpgsqlConnection con = new NpgsqlConnection(connect()))
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM izpisAnketDijak(" + id_ + ");", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string naslov = reader.GetString(1);
                    string url = reader.GetString(2);
                    string opis = reader.GetString(3);
                    string datum = reader.GetString(4);

                    Ankete reading = new Ankete(id, naslov, url, opis, datum);

                    anketeList.Add(reading);
                }
                con.Close();
                return anketeList;
            }
        }

        public static List<Ankete> izpisAnket()
        {
            List<Ankete> anketeList = new List<Ankete>();
            using (NpgsqlConnection con = new NpgsqlConnection(connect()))
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM prikazAnket();", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string naslov = reader.GetString(1);
                    string url = reader.GetString(2);
                    string opis = reader.GetString(3);

                    Ankete reading = new Ankete(id, naslov, url, opis);

                    anketeList.Add(reading);
                }
                con.Close();
                return anketeList;
            }
        }

        public static List<Ankete> searchAnket(string beseda, int id_d)
        {
            List<Ankete> anketeList = new List<Ankete>();
            using (NpgsqlConnection con = new NpgsqlConnection(connect()))
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM searchAnket('" + beseda + "', " + id_d + ");", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string naslov = reader.GetString(1);
                    string url = reader.GetString(2);
                    string opis = reader.GetString(3);

                    Ankete reading = new Ankete(id, naslov, url, opis);

                    anketeList.Add(reading);
                }
                con.Close();
                return anketeList;
            }
        }

        public static void dodajAnketoDijaku(int id_d, int id_a, string datum)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connect()))
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT dodajAnketoDijaku(" + id_d + ", " + id_a + ", '" + datum + "');", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }



                com.Dispose();

                con.Close();
            }
        }

        /*CREATE OR REPLACE FUNCTION izpisAnketDijak(ajdi integer)
RETURNS TABLE(id_a integer, naslov_ varchar, url_ varchar, opis_ varchar, datum_ timestamp)
AS $$
DECLARE

BEGIN
RETURN QUERY
	SELECT a.id, a.naslov, a.url, a.opis, p.datum FROM poslane_ankete p INNER JOIN ankete a ON p.anketa_id=a.id WHERE (p.dijak_id = ajdi);
	
	END;
    $$
    LANGUAGE 'plpgsql'
         * -----------------------------------------------------------------------------------------------------------------------------------------
         * CREATE OR REPLACE FUNCTION prikazAnket()
RETURNS TABLE(id integer, naslov varchar, url varchar, opis varchar)
AS $$
DECLARE

BEGIN
RETURN QUERY
	SELECT a.id, a.naslov, a.url, a.opis FROM ankete a ;


END;
$$
LANGUAGE 'plpgsql'
         *
         *---------------------------------------------------------------------------------------------------------------------------------------
         *CREATE OR REPLACE FUNCTION anketeSearch(beseda varchar, ajdi integer)
RETURNS TABLE(id integer, naslov varchar, url varchar, opis varchar)
AS $$
DECLARE

BEGIN
RETURN QUERY
	SELECT a.id, a.naslov, a.url, a.opis FROM ankete a INNER JOIN poslane_ankete p ON a.id=p.anketa_id WHERE ((a.id LIKE beseda) OR (a.naslov LIKE beseda) OR (a.url LIKE beseda) OR (a.opis LIKE beseda)) AND (p.dijak_id != ajdi);

END;
$$
LANGUAGE 'plpgsql'
         *
         *
         *------------------------------------------------------------------------------------------
         *CREATE OR REPLACE FUNCTION dodajAnketoDijaku(id_d integer, id_a integer, datum_ varchar)
RETURNS VOID
AS $$
DECLARE

BEGIN
INSERT INTO poslane_ankete(dijak_id, anketa_id, datum)
VALUES (id_d, id_a, CAST(datum_ AS timestamp));


END;
$$
LANGUAGE 'plpgsql'
         */

    }
}
