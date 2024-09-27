using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napis kamen nuzky nebo papir");
            int ja = 0;
            int on = 0;
                      
            while (ja < 6 && on < 6) 
            {
                int mojeruka = 0;
                int jehoruka = 0;
                string input = Console.ReadLine();

                switch (input)
                {
                    case "kamen":
                        mojeruka  = 1;
                        break;

                    case "papir":
                        mojeruka = 3;
                        break;
                    case "nuzky":
                        mojeruka = 2;
                        break;

                    default:
                        Console.WriteLine("precti si znova zadani");
                      
                        break;
                }               
                Random rnd = new Random();
                jehoruka = rnd.Next(1,4);
                if (mojeruka == 1)
                {
                    if (jehoruka == 3)
                    {
                        Console.WriteLine("Prohral jsi. Kamen zabalil papír");
                        on++;
                    }
                    if (jehoruka == 2)
                    {
                        Console.WriteLine("VYHRA! Kamen rozbil nuzky");
                        ja++;
                    }
                    if (jehoruka == 1)
                    {
                        Console.WriteLine("Bratře je to remiza");

                    }
                }

                if (mojeruka == 2)
                {
                    if (jehoruka == 3)
                    {
                        Console.WriteLine("Vyhral jsi. Rozstřihal jsi soupeře na padrť");
                        ja++;
                    }
                    if (jehoruka == 2)
                    {
                        Console.WriteLine("REMIZA. Oba dva jste nasadili nuzky. Na to bacha. Je to ostry");

                    }
                    if (jehoruka == 1)
                    {
                        Console.WriteLine("Na tvoje křehké nuzky spadl kamen. Divoch kamen");
                        on++;

                    }
                }

                if (mojeruka == 3)
                {
                    if (jehoruka == 3)
                    {
                        Console.WriteLine("REMÍZA. GRATULUJU 2 papíry tvoří čtvrtku");

                    }
                    if (jehoruka == 2)
                    {
                        Console.WriteLine("PROHRA. Nůžky zubatky se postaraly o tvoji vaporizaci");
                        on++;
                    }
                    if (jehoruka == 1)
                    {
                        Console.WriteLine("VYHRA. Papírem jsi obalil mračícíse balvan. good job nevěsto");
                        ja++;

                    }
                }
                Console.WriteLine("Tvoje score jest " + ja);
                Console.WriteLine("Protivnikovo score jest " + on);
                Console.WriteLine("ZNOVU! napiš kamen nuzky nebo papir ");

            }
            


          
            Console.ReadKey();


            /*
             * Jednoduchy program na procviceni podminek a cyklu.
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem kamen-nuzky-papir.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy skore obou, pripadne cokoliv dalsiho budes potrebovat
             *
             * Opakuj tolikrat, kolik kol chces hrat, nebo treba do doby, nez bude mit jeden z hracu pocet bodu nutnych k vyhre:
             * {
             *      Dokud uzivatel nezada vstup spravne:
             *      {
             *          - nacitej vstup od uzivatele
             *      }
             *      
             *      - vygeneruj s pomoci rng.Next() nahodny vstup pocitace
             *      
             *      Pokud vyhral uzivatel:
             *      {
             *          - informuj uzivatele, ze vyhral kolo
             *          - zvys skore uzivateli o 1
             *      }
             *      Pokud vyhral pocitac:
             *      {
             *          - informuj uzivatele, ze prohral kolo
             *          - zvys skore pocitaci o 1
             *      }
             *      Pokud byla remiza:
             *      {
             *          - informuj uzivatele, ze doslo k remize
             *      }
             * }
             * 
             * - informuj uzivatele, jake mel skore on/a a pocitac a kdo vyhral.
             */

            Random rng = new Random(); //instance tridy Random pro generovani nahodnych cisel



            Console.ReadKey(); //Aby se nam to hnedka neukoncilo
        }
    }
}
