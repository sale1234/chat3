using Biblioteka;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerskiDeo
{
    class Program
    {
        static Server server;
        static void Main(string[] args)
        {
            Console.WriteLine("Pozdrav, unesite email administratora");
            string email = Console.ReadLine();
            Console.WriteLine("Unesite sifru administratora");
            string sifra = Console.ReadLine();
            Administrator administrator = new Administrator
            {
                Email = email,
                Sifra = sifra
            };
            administrator = Kontroler.Instanca.UlogjAdmina(administrator);
            if(administrator != null)
            {
                Console.WriteLine($"Dobrodosli {administrator.Ime} {administrator.Prezime}");
            }
            string opcija;
            do
            {
                Console.WriteLine("Korisnicki meni");
                Console.WriteLine("Opcija 1: Pokreni serverski program");
                Console.WriteLine("Opcija 2: Zaustavi serverski program");
                Console.WriteLine("Opcija 3: Unesi novog korisnika sistema");
                Console.WriteLine("Opcija 4: Prikazi sve poruke");
                Console.WriteLine("Opcija 0: Ugasi server program i sve klijente");
                Console.WriteLine("Unesite opciju koju zelite");
                opcija = Console.ReadLine();
                switch (opcija)
                {
                    case "1":
                        Console.WriteLine("Izabrali ste pokretanje servera");
                        try
                        {
                            server = new Server();
                            server.Start();
                            Thread nit = new Thread(server.ObradiKlijente);
                            nit.Start();
                            Console.WriteLine("Server je pokrenut");
                        }
                        catch (SocketException ex)
                        {
                            Debug.WriteLine(ex.Message);
                        }
                        
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("Izabrali ste zaustavljanje servera");
                            server?.Close();
                            server = null;
                            Console.WriteLine("Server je iskljucen");

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Izabrali ste dodavanje novog korisnika");
                        Console.WriteLine("Unesite korisnicko ime");
                        string ime = Console.ReadLine();
                        Console.WriteLine("Unesite sifru");
                        string password = Console.ReadLine();
                        if(ime.All(Char.IsLetter) && password.Any(Char.IsLetter) && password.Any(Char.IsDigit) && password.Length >= 2)
                        {
                            Korisnik korisnik = new Korisnik
                            {
                                KorisnickoIme = ime,
                                KorisnickaSifra = password
                            };
                            Kontroler.Instanca.DodajKorisnika(korisnik);
                            Console.WriteLine("Korisnik je uspesno dodat");
                        }
                        else
                        {
                            Console.WriteLine("Nisu lepo uneti podaci, ime mora da ima samo slova, a sifra da sadrzi bar jedno slovo i jedan broj");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Izabrali ste opciju za prikaz svih poruka");
                        List<Poruka> poruke = Kontroler.Instanca.VratiPoruke();
                        foreach (var poruka in poruke)
                        {
                            Console.WriteLine(poruka.Tekst);
                        }
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } while (opcija != "-1");
            Console.ReadKey();
        }

        
    }
}
