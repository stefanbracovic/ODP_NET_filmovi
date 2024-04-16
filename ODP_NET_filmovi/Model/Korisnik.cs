using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODP_NET_filmovi.Model
{
    public class Korisnik
    {
        public string KorImek { get; set; }
        public string Imek { get; set; }
        public string Przk { get; set; }
        public string Polk { get; set; }
        public string Aktivank { get; set; }

        public Korisnik() { }

        public Korisnik(string korImek, string imek, string przk, string polk, string aktivank)
        {
            KorImek = korImek;
            Imek = imek;
            Przk = przk;
            Polk = polk;
            Aktivank = aktivank;
        }

        public static string getFormattedHeader()
        {
            return string.Format("{0,-25} {1,-15} {2,-15} {3,-4} {4,-8}", "KORIMEK", "IMEK", "PRZK", "POLK", "AKTIVANK");
        }
        public override string ToString()
        {
            return string.Format("{0,-25} {1,-15} {2,-15} {3,-4} {4,-8}", KorImek, Imek, Przk, Polk, Aktivank);
        }

    }
}
