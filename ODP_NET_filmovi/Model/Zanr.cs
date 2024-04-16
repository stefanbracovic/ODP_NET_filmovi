using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODP_NET_filmovi.Model
{
    public class Zanr
    {
        public int Idz { get; set; }
        public string Nazivz { get; set; }

        public Zanr() { }

        public Zanr(int idz, string nazivz)
        {
            Idz = idz;
            Nazivz = nazivz;
        }

        public static string getFormattedHeader()
        {
            return string.Format("{0,-4} {1,-20}", "IDZ", "NAZIVZ");
        }
        public override string ToString()
        {
            return string.Format("{0,-4} {1,-20}", Idz, Nazivz);
        }
    }
}
