using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [Serializable]
    public class Poruka
    {
        public string Tekst { get; set; }
        public Operacija Operacija { get; set; }

        public Korisnik Posiljalac { get; set; }
        public Korisnik Primalac { get; set; }
        public List<Korisnik> UlogovaniKorisnici { get; set; }

        public bool Uspesno { get; set; }
    }

    public enum Operacija
    {
        Login,
        SaljiSvima
    }
}
