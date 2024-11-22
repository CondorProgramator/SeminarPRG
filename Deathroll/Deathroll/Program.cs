using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace Deathroll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Jednoduchy program na procviceni podminek a cyklu (lze udelat i rekurzi).
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem deathroll.
             * Pravidla deathrollu: Prvni hrac navrhne cislo (puvodne ve wowku pocet goldu, o ktere se hraci vsadi) a "rollne" navrhnute cislo, jinak receno je to stejne,
             * jako kdyby si hodil kostkou s tolika stenami, jako je navrhnute cislo. Prvnimu hraci "padne" nejake cislo a druhy hrac si "rollne" padnute cislo
             * (ktere uz je mensi nez to predesleho hrace).
             * Prohrava ten hrac, kteremu padne 1 jako prvnimu.
             * Ukazka hry: Hraci se shodnou na cisle 1000. Prvni hrac rollne 1-1000, padne mu 920. Druhy hrac rolluje 1-920, padne mu 235 atd. atd. az jednomu z hracu padne 1
             * a ten prohrava.
             * 
             * Struktura: 

             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy aktualne rollovane cislo a stav "goldu" uzivatele i pocitace (oba zacinaji treba s 1000 goldu)
             * 
             * - uzivatel zada prvotni sazku, ktera musi byt maximalne tolik, kolik ma goldu
             * 
             * Opakuj dokud nepadne jednomu z hracu 1:
             * {
             *      Pokud je sude kolo:
             *      {
             *          - uzivatel zada hodnotu, kterou rolluje
             *          - kontroluj, ze uzivatel zadal spravnou hodnotu
             *          - uloz rollnute cislo
             *          - vypis uzivateli, co rollnul
             *      }
             *      Pokud je liche kolo:
             *      {
             *          - pocitac rollne nahodne cislo mezi 1 a aktualne rollovanym cislem
             *          - vypis uzivateli, co rollnul pocitac
             *      }
             * }
             * 
             * 
             * - posledni hrajici hrac prohral, protoze mu padla 1 a sazku bere druhy hrac
             * - vypis uzivateli kdo vyhral a stav goldu uzivatele i pocitace
             * 
             * ROZSIRENI:
             * - umozni uzivateli opakovat deathroll dokud ma nejake goldy
             */
            int wallet = 1000;
            int betano = 0;
            int comp = 0;
            int money = 0;

            Console.WriteLine("DEATHROLL");
            while (true)
            {
                Console.WriteLine("Kolik vsadíš? Aktuální zůstatek " + wallet);
                try


                {
                    string input = Console.ReadLine();
                    money = int.Parse(input);
                    comp = int.Parse(input);
                    if (comp > wallet)
                    {
                        Console.WriteLine("Nemáš tolik peněz. Jsi diskvalifikován");
                        Console.ReadKey();
                        return;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Neplatný input");
                    return;
                }

                Random rnd = new Random();
                while (betano != 1 && comp != 1)
                {
                    betano = rnd.Next(1, comp);
                    Console.WriteLine("Ty " + betano);
                    Console.ReadKey();
                    if (betano == 1)
                    {
                        break;
                    }

                    Random rnd2 = new Random();
                    comp = rnd2.Next(1, betano);
                    Console.WriteLine("On " + comp);
                    Console.ReadKey();
                }

                if (betano == 1)
                {
                    Console.WriteLine("Prhrál jsi. Padle ti " + betano + "    (-" + money + ")");
                    wallet = wallet-money;
                }

                else
                {
                    Console.WriteLine("Vyhrál jsi. Soupeřovi padlo " + comp + "    (+" + money + ")");
                    wallet = wallet+money;
                }

                Console.ReadKey();

               

                continue;

                Console.ReadKey();
            }
        }
    }
}

