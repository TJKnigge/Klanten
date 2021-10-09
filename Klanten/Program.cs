using System;
using System.Collections.Generic;
using System.Linq;


namespace Klanten
{
    class Program
    {
        public class Klant
        {
            public string Id { get; set; }
            public string Naam { get; set; }
        }

        public class Achtenaam
        {
            public string Id { get; set; }
            public string KlantId { get; set; }
            public string geboortenaam { get; set; }
        }

        public class Straatnaam
        {
            public string Id { get; set; }
            public string AchternaamId { get; set; }
            public string straat { get; set; }
        }

        public class Wonen
        {
            public string Id { get; set; }
            public string StraatnaamId { get; set; }
            public string wonen { get; set; }
        }

        static string check()
        {
            var vraag = Console.ReadLine();       // singel point of definition
            if (vraag == "")
            {
                Console.WriteLine("geef nog een keer");
                vraag = Console.ReadLine();

            }
            return vraag;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("aantalklanten: ");
            string input = Console.ReadLine();
            int ID;
            Int32.TryParse(input, out ID);


            for (int b = 0; b < ID; b++)

            {

                Console.WriteLine("geef naam");
                var naam = check();

                Console.WriteLine("geef achternaam");
                var achternaam = check();

                Console.WriteLine("geef straatnaam");
                var straatnaam = check();

                Console.WriteLine("geef woonplaats");
                var woonplaats = check();


                Console.WriteLine("\n");

                Console.WriteLine($"{naam} U kunt uw betelling op geven!");

                Console.WriteLine("\n");

                // Voor het vrij invullen van de klant gegevens kan dit gebruikt worden, versie 2

                /*
                 Console.WriteLine("aantalklanten: "); 
            //string input = Console.ReadLine();
            //int ID;
            //Int32.TryParse(input, out ID);

            var aantal = Console.ReadLine();
            var aantalklanten = int.Parse(aantal);

            //for (int b = 0; b < ID.Length; b++)

            //{ 

            //Console.WriteLine("geef naam");
            //var naam = check();


            //Console.WriteLine("geef achternaam");
            //var achternaam = check();

            //Console.WriteLine("geef straatnaam");
            //var straatnaam = check();

            //Console.WriteLine("geef woonplaats");
            //var woonplaats = check();


               //Console.WriteLine("\n");

               //Console.WriteLine($"{naam} U kunt uw betelling op geven!");
               
               // Console.WriteLine("\n");



                //Console.Write("geef aub het aantal medewerkers op:");
                //var aantal = Console.ReadLine();
                //var aantalmedewerkers = int.Parse(aantal);

                var ID = new int[aantalklanten];
                var naam = new string[aantalklanten];                
                var achternaaam = new string[aantalklanten];
                var straat = new string[aantalklanten];
                var postcode = new string[aantalklanten];
                var woonplaats = new string[aantalklanten];



            for (int i = 0; i < ID.Length; i++)
                {
                    Console.WriteLine("geef aub uw naam op ", i);
                    naam[i] = check();
                    Console.WriteLine("geef aub uw achternamen op ", i);
                    achternaaam[i] = check();
                    Console.WriteLine("geef aub uw strtaatnaam op ", i);
                    straat[i] = check();
                    Console.WriteLine("geef aub uw woonplaats op ", i);
                    woonplaats[i] = check();


                try
                    {
                        Console.WriteLine("geef aub uw postcode op ", i);
                        postcode[i] = check();
                        Console.WriteLine("geef aub ID van klanten op", i);
                        ID[i] = int.Parse(Console.ReadLine());

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("Je hebt geen cijfer op gegeven");
                    }


                }

            Console.WriteLine("\n");

            Console.WriteLine("{naam[i]} U kunt uw betelling op geven!");
            Console.WriteLine("\n");

            Console.WriteLine("ID:    \t |  Naam:     \t |  Achternaam:    \t |  Straatnaam:   \t |  Poatcode:  \t  |  Woonplaats");
                for (int i = 0; i < ID.Length; i++)
                {
                    Console.WriteLine("  {0}   \t |    {1}   \t |    {2}   \t\t |    {3}   \t\t |    {4}   \t    {5}", ID[i], naam[i], achternaaam[i], straat[i], postcode[i], woonplaats[i]);
                    
                }

            Console.WriteLine("\n");

            Console.WriteLine("{naam[i]} U kunt uw betelling op geven!");

            Console.WriteLine("\n");
                */

                string naam1 = naam;
                var klant = new List<Klant>()
            {
                 new Klant()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Jan"
                 },
                 new Klant()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Piet"
                 },
                 new Klant()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Klaas"
                 },
                 new Klant()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Johan"
                 },
                 new Klant()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Theo"
                 },
                 new Klant()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "THijs"
                 },
                 new Klant()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Harry"
                 },
                 new Klant()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Karel"
                 },
                 new Klant()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Kees"
                 },
                 new Klant()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Corne"
                 }
            };
                string achternaam1 = achternaam;
                var geboortenaam = new List<Achtenaam>()
            {
            new Achtenaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     KlantId = klant[0].Id,
                     geboortenaam = "de Groot"
                  },
            new Achtenaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     KlantId = klant[1].Id,
                     geboortenaam = "Jansen"
                  },
            new Achtenaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     KlantId = klant[2].Id,
                     geboortenaam = "Meerveld"
                  },
            new Achtenaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     KlantId = klant[3].Id,
                     geboortenaam = "Timmers"
                  },
            new Achtenaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     KlantId = klant[4].Id,
                     geboortenaam = "Peters"
                  },
            new Achtenaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     KlantId = klant[5].Id,
                     geboortenaam = "Rietveld"
                  },
            new Achtenaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     KlantId = klant[6].Id,
                     geboortenaam = "Meesters"
                  },
            new Achtenaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     KlantId = klant[7].Id,
                     geboortenaam = "de Klein"
                  },
            new Achtenaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     KlantId = klant[8].Id,
                     geboortenaam = "Smit"
                  },
            new Achtenaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     KlantId = klant[9].Id,
                     geboortenaam = "van Dijk"
                  }
            };
                string straatnaam1 = straatnaam;
                var straat = new List<Straatnaam>()
            {
            new Straatnaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = geboortenaam[0].Id,
                     straat = straatnaam1
                  },
            new Straatnaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = geboortenaam[0].Id,
                     straat = "Sationsplain 4"
                  },
            new Straatnaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = geboortenaam[01].Id,
                     straat = "Langestraat 1"
                  },
            new Straatnaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = geboortenaam[2].Id,
                     straat = "Braamslaan 9"
                  },
            new Straatnaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = geboortenaam[3].Id,
                     straat = "Haaglaan 2"
                  },
            new Straatnaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = geboortenaam[4].Id,
                     straat = "Stationstraat 6"
                  },
            new Straatnaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = geboortenaam[5].Id,
                     straat = "Klarenbeek  7"
                  },
            new Straatnaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = geboortenaam[6].Id,
                     straat = "Prinsegracht 3"
                  },
            new Straatnaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = geboortenaam[7].Id,
                     straat = "Teilstraat 5"
                  },
            new Straatnaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = geboortenaam[8].Id,
                     straat = "Dwarsstraat 1"
                  },
            new Straatnaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = geboortenaam[9].Id,
                     straat = "Doornlaan 8"
                  }
            };

                string woonplaats1 = woonplaats;
                var wonen = new List<Wonen>()
            {
            new Wonen()
                 {
                     Id = Guid.NewGuid().ToString(),
                     StraatnaamId = straat[0].Id,
                     wonen = "den Haag"
                  },
            new Wonen()
                 {
                     Id = Guid.NewGuid().ToString(),
                     StraatnaamId = straat[1].Id,
                     wonen = "Haarlem"
                  },
            new Wonen()
                 {
                     Id = Guid.NewGuid().ToString(),
                     StraatnaamId = straat[2].Id,
                     wonen = "den Bilt"
                  },
            new Wonen()
                 {
                     Id = Guid.NewGuid().ToString(),
                     StraatnaamId = straat[3].Id,
                     wonen = "Zwolle"
                  },
            new Wonen()
                 {
                     Id = Guid.NewGuid().ToString(),
                     StraatnaamId = straat[4].Id,
                     wonen = "Meppel"
                  },
            new Wonen()
                 {
                     Id = Guid.NewGuid().ToString(),
                     StraatnaamId = straat[5].Id,
                     wonen = "Goes"
                  },
            new Wonen()
                 {
                     Id = Guid.NewGuid().ToString(),
                     StraatnaamId = straat[6].Id,
                     wonen = "Emmen"
                  },
            new Wonen()
                 {
                     Id = Guid.NewGuid().ToString(),
                     StraatnaamId = straat[7].Id,
                     wonen = "Breda"
                  },
            new Wonen()
                 {
                     Id = Guid.NewGuid().ToString(),
                     StraatnaamId = straat[8].Id,
                     wonen = "Epe"
                  },
            new Wonen()
                 {
                     Id = Guid.NewGuid().ToString(),
                     StraatnaamId = straat[9].Id,
                     wonen = "Arnhem" 
                  }
            };

                var result = from k in klant
                             join a in geboortenaam on k.Id equals a.KlantId
                             join s in straat on a.Id equals s.AchternaamId
                             join w in wonen on s.Id equals w.StraatnaamId
                             select new
                             {
                                 k.Naam,
                                 a.geboortenaam,
                                 s.straat,
                                 w.wonen
                             };

                foreach (var resultItem in result)
                {
                    Console.WriteLine($"{resultItem.Naam} {0,-5} \t{""} {"||"}  {resultItem.geboortenaam} \t{""} {"||"} {resultItem.straat} \t{""} {"||"} {resultItem.wonen}");
                }

                Console.WriteLine("\n");

                
            }
        }
    }
}
