using System;
using System.Collections.Generic;
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
            int mojeruka = 0;
            int jehoruka = 0;
            string input = Console.ReadLine();
            if (input == "kamen") 
            {
                mojeruka = 1; 
            }           
            if (input == "nuzky")
            {
                mojeruka = 2;
            }
            if (input == "papir")
            {
                mojeruka = 3;
            }

            Random rnd = new Random();
            

            for (int i = 0; i < 4; i++)
            {
            

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
