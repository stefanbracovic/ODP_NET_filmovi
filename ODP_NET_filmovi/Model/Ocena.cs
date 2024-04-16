using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODP_NET_filmovi.Model
{
    public class Ocena
    {
        public int Ido { get; set; }
        public string KorImeo { get; set; }
        public int Filmo { get; set; }
        public int Ocenao { get; set; }
        public string Vazecao { get; set; }

        public Ocena() { }

        public Ocena(int ido, string korImeo, int filmo, int ocenao, string vazecao)
        {
            Ido = ido;
            KorImeo = korImeo;
            Filmo = filmo;
            Ocenao = ocenao;
            Vazecao = vazecao;
        }

        public static string getFormattedHeader()
        {
            return string.Format("{0,-4} {1,-25} {2,-5} {3,-6} {4,-7}", "IDO", "KORIMEO", "FILMO", "OCENAO", "VAZECAO");
        }
        public override string ToString()
        {
            return string.Format("{0,-4} {1,-25} {2,-5} {3,-6} {4,-7}", Ido, KorImeo, Filmo, Ocenao, Vazecao);
        }

    }
}
