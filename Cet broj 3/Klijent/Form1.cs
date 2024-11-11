using Biblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class Form1 : Form
    {
        private BindingList<Poruka> svePoruke = new BindingList<Poruka>();
        public Form1()
        {
            InitializeComponent();
            gbLogovanje.Visible = true;
            gbPorukeOdredjenom.Visible = false;
            gbPorukeSvima.Visible = false;
            gbSvePoruke.Visible = false;
            try
            {
                Komunikacija.Instanca.Connect();
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik
            {
                KorisnickoIme = txtIme.Text,
                KorisnickaSifra = txtSifra.Text
            };
            Poruka poruka = new Poruka
            {
                Posiljalac = korisnik,
                Operacija = Operacija.Login
            };
            Komunikacija.Instanca.PosaljiPoruku(poruka);
            Poruka odgovor = Komunikacija.Instanca.CitajPoruku();
            if(odgovor.Uspesno)
            {
                MessageBox.Show($"Dobrodosli {odgovor.Primalac.KorisnickoIme}");
                gbLogovanje.Visible = false;
                gbPorukeOdredjenom.Visible = true;
                gbPorukeSvima.Visible = true;
                gbSvePoruke.Visible = true;
                SlusajPoruke();
            }
            else
            {
                MessageBox.Show("Neuspesna prijava pokusajte ponovo");
            }
        }

        private void SlusajPoruke()
        {
            Thread nit = new Thread(ObradiPoruke);
            nit.Start();
        }

        private void ObradiPoruke()
        {
            try
            {
                while (true)
                {
                    Poruka odgovor = Komunikacija.Instanca.CitajPoruku();
                    switch (odgovor.Operacija)
                    {
                        case Operacija.Login:
                            Invoke(new Action(() =>
                            {
                                cbKorisnici.DataSource = odgovor.UlogovaniKorisnici;
                            }));
                            break;
                        case Operacija.SaljiSvima:
                            Invoke(new Action(() =>
                            {
                                if (svePoruke.Count < 3)
                                {
                                    svePoruke.Add(odgovor);
                                    dgvPoslednje3.DataSource = svePoruke;
                                }
                                else
                                {
                                    svePoruke.Add(odgovor);
                                    dgvOstale.DataSource = svePoruke.Take(svePoruke.Count - 3).ToList();
                                    dgvPoslednje3.DataSource = svePoruke.Except(svePoruke.Take(svePoruke.Count - 3).ToList()).ToList();
                                }
                            }));
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (SerializationException)
            {
                MessageBox.Show("Doslo je do prekida komunikacije sa serverom");
                Environment.Exit(0);
            }

        }

        private void btnSaljiSvima_Click(object sender, EventArgs e)
        {
            try
            {
                Poruka poruka = new Poruka
                {
                    Tekst = rtbSaljiSvima.Text,
                    Primalac = new Korisnik
                    {
                        KorisnickoIme = "svi korisnici"
                    },
                    Operacija = Operacija.SaljiSvima
                };
                Komunikacija.Instanca.PosaljiPoruku(poruka);

            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSlanjeOdredjenom_Click(object sender, EventArgs e)
        {
            try
            {
                Poruka poruka = new Poruka
                {
                    Tekst = rtbSaljiSvima.Text,
                    Primalac = (Korisnik)cbKorisnici.SelectedItem,
                    Operacija = Operacija.SaljiSvima
                };
                Komunikacija.Instanca.PosaljiPoruku(poruka);

            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}