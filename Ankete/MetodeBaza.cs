using System;
using Npgsql;
using System.Collections.Generic;
using System.Configuration;

namespace Ankete
{
    public class BazaConn
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
    }


    public class MetodeBaza
    {

        List<Kraji> krajiList = new List<Kraji>();

        string connect = BazaConn.connect();

        public List<Kraji> izpisKrajev()
        {

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
                return krajiList;
            }
        }

        public void registracija(string email, string geslo, string naziv)
        {


            using (NpgsqlConnection con = new NpgsqlConnection(connect))
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("INSERT INTO registracija(admin_email, password('" + naziv + "', '" + email + "', '" + geslo + "', '"  + naziv + "');", con);
    
                com.ExecuteNonQuery();

                com.Dispose();

                con.Close();
            }   
        }



    }
}
