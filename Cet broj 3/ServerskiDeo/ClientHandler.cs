using Biblioteka;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServerskiDeo
{
    public class ClientHandler
    {
        private Socket klijentSoket;
        private List<ClientHandler> clients;
        private CommunicationHelper helper;
        private List<Korisnik> korisnici;

        public ClientHandler(Socket klijentSoket, List<ClientHandler> clients, List<Korisnik> korisnici)
        {
            this.klijentSoket = klijentSoket;
            this.clients = clients;
            this.korisnici = korisnici;
            helper = new CommunicationHelper(klijentSoket);
        }

        internal void ObradiZahteve()
        {
            try
            {
                while (!kraj)
                {
                    Poruka poruka = helper.CitajPoruku<Poruka>();
                    switch (poruka.Operacija)
                    {
                        case Operacija.Login:
                            Login(poruka);
                            break;
                        case Operacija.SaljiSvima:
                            SaljiSvima(poruka);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                CloseSoket();
            }
        }

        private void SaljiSvima(Poruka poruka)
        {
            poruka.Posiljalac = UlogovaniKorisnik;
            if (poruka.Tekst != null) Kontroler.Instanca.DodajPoruku(poruka);
            foreach (var klijent in clients)
            {
                if (klijent.UlogovaniKorisnik != null) klijent.helper.SaljiPoruku(poruka);
            }
        }

        public Korisnik UlogovaniKorisnik { get; set; }

        private void Login(Poruka poruka)
        {
            bool ulogovan = false;
            foreach (var korisnik in korisnici)
            {
                if (korisnik.KorisnickoIme == poruka.Posiljalac.KorisnickoIme && korisnik.KorisnickaSifra == poruka.Posiljalac.KorisnickaSifra)
                {
                    ulogovan = true;
                    UlogovaniKorisnik = korisnik;
                }
            }
            if (ulogovan)
            {
                korisnici.Remove(UlogovaniKorisnik);
                Kontroler.Instanca.DodajUlogovane(UlogovaniKorisnik);
                Poruka odgovor = new Poruka
                {
                    Uspesno = true,
                    Primalac = UlogovaniKorisnik
                };
                helper.SaljiPoruku(odgovor);
                Poruka zaSve = new Poruka
                {
                    UlogovaniKorisnici = Kontroler.Instanca.VratiUlogovane()
                };
                SaljiSvima(zaSve);
            }
            else
            {
                Poruka odgovor = new Poruka
                {
                    Uspesno = false
                };
            }

        }

        public EventHandler OdjavljeniKlijent;
        private object lockObject = new object();
        private bool kraj = false;

        internal void CloseSoket()
        {
            try
            {
                lock (lockObject)
                {
                    if (klijentSoket != null)
                    {
                        kraj = true;
                        klijentSoket.Shutdown(SocketShutdown.Both);
                        klijentSoket.Close();
                        klijentSoket = null;
                        OdjavljeniKlijent?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
            catch (System.Runtime.Serialization.SerializationException ex)
            {
                Debug.WriteLine(">>>>" + ex.Message);
            }
        }
    }
}
