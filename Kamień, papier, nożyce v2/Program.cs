using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamień__papier__nożyce_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random liczbaLosowa = new Random();
            char gramy = 't';
            int wygrana = 0;
            int przegrana = 0;
            int remis = 0;
            while (gramy == 't')
            {
                int liczbaPrzeciwnika = liczbaLosowa.Next(1, 4);
                Console.WriteLine("Wybierz:");
                Console.WriteLine("1. Kamień");
                Console.WriteLine("2. Papier");
                Console.WriteLine("3. Nożyce");
                int wybor = int.Parse(Console.ReadLine());
                string cos = "";

                switch(liczbaPrzeciwnika)
                {
                    case 1:
                        cos = "kamień";
                        break;

                    case 2:
                        cos = "papier";
                        break;

                    case 3:
                        cos = "nożyce";
                        break;
                }


                if (wybor == liczbaPrzeciwnika)
                {
                    Console.WriteLine("Przeciwnik wybrał {0}.", cos);
                    Console.WriteLine("Remis!");
                    remis++;
                }
                else
                {
                    if ((3 + wybor - liczbaPrzeciwnika) % 3 == 1)
                    {
                        wygrana++;
                        Console.WriteLine("Przeciwnik wybrał {0}. Wygrałeś!", cos);
                    }
                    else if ((3 + wybor - liczbaPrzeciwnika) % 3 == 2)
                    {
                        przegrana++;
                        Console.WriteLine("Przeciwnik wybrał {0}. Przegrałeś.", cos);
                    }
                }

                Console.WriteLine("Gramy dalej? (t/n)");
                Console.WriteLine("");
                gramy = char.Parse(Console.ReadLine());

            }
            Console.WriteLine("Wygrana: {0}", wygrana);
            Console.WriteLine("Remis: {0}", remis);
            Console.WriteLine("Przegrana {0}", przegrana);
            Console.ReadKey();
        }

    }
}
