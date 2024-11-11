using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerskiDeo
{
    public class Kontroler
    {
        private static Kontroler instanca;

        private Kontroler()
        {

        }

        public static Kontroler Instanca 
        { 
            get
            {
                if (instanca == null) instanca = new Kontroler();
            return instanca;

            }
        }

        internal List<Korisnik> VratiKorisnike()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiKorisnike();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        private Broker broker = new Broker();

        internal Administrator UlogjAdmina(Administrator administrator)
        {
            try
            {
                broker.OpenConnection();
                List<Administrator> lista = broker.VratiAdmine();
                foreach (var admin in lista)
                {
                    if (admin.Email == administrator.Email && admin.Sifra == administrator.Sifra) return admin;
                }
                return null;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal void DodajKorisnika(Korisnik korisnik)
        {
            try
            {
                broker.OpenConnection();
                broker.DodajKorisnika(korisnik);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal List<Poruka> VratiPoruke()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiPoruke();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal void DodajPoruku(Poruka poruka)
        {
            try
            {
                broker.OpenConnection();
                broker.DodajPoruku(poruka, ulogovaniKorisnici);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        private List<Korisnik> ulogovaniKorisnici = new List<Korisnik>();

        internal void DodajUlogovane(Korisnik ulogovaniKorisnik)
        {
            ulogovaniKorisnici.Add(ulogovaniKorisnik);
        }

        internal List<Korisnik> VratiUlogovane()
        {
            return ulogovaniKorisnici;
        }
    }
}
