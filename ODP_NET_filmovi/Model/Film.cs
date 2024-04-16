using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODP_NET_filmovi.Model
{
    public class Film
    {
        public int Idf { get; set; }
        public int Zanrf { get; set; }
        public string Nazivf { get; set; }
        public int Trajanjef { get; set; }
        public int Godf { get; set; }

        public Film() { }

        public Film(int idf, int zanrf, string nazivf, int trajanjef, int godf)
        {
            Idf = idf;
            Zanrf = zanrf;
            Nazivf = nazivf;
            Trajanjef = trajanjef;
            Godf = godf;
        }

        public static string getFormattedHeader()
        {
            return string.Format("{0,-4} {1,-30} {2,-5} {3,-10} {4,-4}", "IDF", "NAZIVF", "ZANRF", "TRAJANJEF", "GODF");
        }
        public override string ToString()
        {
            return string.Format("{0,-4} {1,-30} {2,-5} {3,-10} {4,-4}", Idf, Nazivf, Zanrf, Trajanjef, Godf);
        }

    }
}
