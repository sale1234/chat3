using Biblioteka;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerskiDeo
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlCommand command;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Chat;Integrated Security=True;");
            command = new SqlCommand("", connection);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        internal List<Korisnik> VratiKorisnike()
        {
            command.CommandText = "select * from korisnik";
            SqlDataReader reader = command.ExecuteReader();
            List<Korisnik> lista = new List<Korisnik>();
            while (reader.Read())
            {
                Korisnik korisnik = new Korisnik
                {
                    KorisnickoIme = reader.GetString(0),
                    KorisnickaSifra = reader.GetString(1)
                };
                lista.Add(korisnik);
            }
            reader.Close();
            return lista;
        }

        internal List<Administrator> VratiAdmine()
        {
            command.CommandText = "select * from administrator";
            SqlDataReader reader = command.ExecuteReader();
            List<Administrator> lista = new List<Administrator>();
            while(reader.Read())
            {
                Administrator administrator = new Administrator
                {
                    Email = reader.GetString(1),
                    Sifra = reader.GetString(2),
                    Ime = reader.GetString(3),
                    Prezime = reader.GetString(4)
                };
                lista.Add(administrator);
            }
            reader.Close();
            return lista;
        }

        internal void DodajKorisnika(Korisnik korisnik)
        {
            command.CommandText = "insert into korisnik values (@ime, @sifra)";
            command.Parameters.AddWithValue("@ime", korisnik.KorisnickoIme);
            command.Parameters.AddWithValue("@sifra", korisnik.KorisnickaSifra);
            command.ExecuteNonQuery();
        }

        internal void DodajPoruku(Poruka poruka, List<Korisnik> ulogovaniKorisnici)
        {
            foreach (var korisnik in ulogovaniKorisnici)
            {
                command.CommandText = "insert into poruka values (@tekst, @posiljalac, @primalac)";
                command.Parameters.AddWithValue("@tekst", poruka.Tekst);
                command.Parameters.AddWithValue("@posiljalac", poruka.Posiljalac.KorisnickoIme);
                command.Parameters.AddWithValue("@primalac", korisnik.KorisnickoIme);
                command.ExecuteNonQuery();
            }
                
        }

        internal List<Poruka> VratiPoruke()
        {
            command.CommandText = "select * from poruka";
            SqlDataReader reader = command.ExecuteReader();
            List<Poruka> lista = new List<Poruka>();
            while (reader.Read())
            {
                Poruka poruka = new Poruka
                {
                    Tekst = reader.GetString(1)
                };
                lista.Add(poruka);
            }
            reader.Close();
            return lista;
        }
    }
}
