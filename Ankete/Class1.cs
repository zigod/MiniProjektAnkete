using System;
using Npgsql;
using MiniProjektAnkete;
using System.Collections.Generic;
using System.Configuration;

namespace Ankete
{
    public class Metode
    {

        List<Kraji> krajiList = new List<Kraji>();

        public void izpisKrajev()
        {

            string connect = BazaConn.connect();

            

            using (NpgsqlConnection con = new NpgsqlConnection(connect))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM izpisKrajev()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string imeKraja = reader.GetString(0);
                    int postnaSt = reader.GetInt32(1);

                    Kraji reading = new Kraji(imeKraja, postnaSt);

                    krajiList.Add(reading);

                }
                con.Close();
            }
        }
    }

    public class Kraji
    {
        public string ime { get; set; }
        public int postnaSt { get; set; }
        public Kraji(string name, int postNum)
        {
            this.ime = name;
            this.postnaSt = postNum;
        }

        public Kraji(string name)
        {
            this.ime = name;
        }
    }
}
