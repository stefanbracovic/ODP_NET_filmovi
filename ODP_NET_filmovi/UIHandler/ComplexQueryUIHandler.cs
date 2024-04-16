using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODP_NET_filmovi.UIHandler
{
    public class ComplexQueryUIHandler
    {

        // TODO uncomment
        // private static readonly OcenaService ocenaService = new OcenaService();
        // private static readonly ZanrService zanrService = new ZanrService();
        // private static readonly KorisnikService korisnikService = new KorisnikService();
        // private static readonly FilmService filmService = new FilmService();

        public void HandleComplexQueryMenu()
        {
            string answer;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Odaberite funkcionalnost:");
                Console.WriteLine("1  - ");
                Console.WriteLine("2  - ");
                Console.WriteLine("3  - ");
                Console.WriteLine("X  - Izlazak iz kompleksnih upita");

                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
						//TODO:
                        break;
                    case "2":
						//TODO:
                        break;  
                    case "3":
						//TODO:
                        break;                    
                }

            } while (!answer.ToUpper().Equals("X"));
        } 

    }
}
