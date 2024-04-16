using ODP_NET_filmovi.UIHandler;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: uneti broj indeksa, ime i prezime
//

namespace ODP_NET_filmovi
{
    class Program
    {

        private static readonly MainUIHandler mainUIHandler = new MainUIHandler();

        static void Main(string[] args)
        {
            mainUIHandler.HandleMainMenu();
        }
    }
}
