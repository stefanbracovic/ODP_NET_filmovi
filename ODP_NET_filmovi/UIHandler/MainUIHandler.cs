using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODP_NET_filmovi.UIHandler
{
    public class MainUIHandler
    {
        private readonly FilmUIHandler filmUIHandler = new FilmUIHandler();
        private readonly ZanrUIHandler zanrUIHandler = new ZanrUIHandler();
        private readonly KorisnikUIHandler korisnikUIHandler = new KorisnikUIHandler();
        private readonly OcenaUIHandler ocenaUIHandler = new OcenaUIHandler();
        private readonly ComplexQueryUIHandler complexQueryUIHandler = new ComplexQueryUIHandler();

        public void HandleMainMenu()
        {
            string answer;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Odaberite opciju:");
                Console.WriteLine("1 - Rukovanje filmovima");
                Console.WriteLine("2 - Rukovanje zanrovima");
                Console.WriteLine("3 - Rukovanje korisnicima");
                Console.WriteLine("4 - Rukovanje ocenama");
                Console.WriteLine("5 - Kompleksni upiti");
                Console.WriteLine("X - Izlazak iz programa");

                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        filmUIHandler.HandleMenu();
                        break;
                    case "2":
                        zanrUIHandler.HandleMenu();
                        break;
                    case "3":
                        korisnikUIHandler.HandleMenu();
                        break;
                    case "4":
                        ocenaUIHandler.HandleMenu();
                        break;
                    case "5":
                        complexQueryUIHandler.HandleComplexQueryMenu();
                        break;
                }

            } while (!answer.ToUpper().Equals("X"));
        }
    }
}
