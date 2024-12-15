using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RealBattleShip
{
    internal class Program
    {

        // Nakreslení pole

        static void DrawField(int[,] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToPrint.GetLength(1); j++)
                {
                    // Vyměním číslo znakem
                    if (arrayToPrint[i, j] == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("(3)");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (arrayToPrint[i, j] == 2)
                    {
                        Console.Write("(2)"); // Udělám si pole
                    }
                    else if (arrayToPrint[i, j] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("[X]");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (arrayToPrint[i, j] == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("[O]");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (arrayToPrint[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("[ ]");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------");
        }

        // Funkce na založení pole
        static void SetArrayToDefault(int[,] arrayToSet, int[,] arrayPC, int[,] arrayShadow)
        {
            for (int i = 0; i < arrayToSet.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToSet.GetLength(1); j++)
                {
                    arrayToSet[i, j] = 0;
                    arrayPC[i, j] = 0;
                    arrayShadow[i, j] = 0;
                }
            }
        }

        // Funkce pro ověření místa na umístění pole
        static bool CanPlaceShip(int[,] array, int x, int y, int length, bool isHorizontal)
        {
            if (isHorizontal)
            {
                if (y + length > array.GetLength(1)) return false; // Přesahuje hranice

                for (int j = 0; j < length; j++)
                {
                    if (array[x, y + j] != 0) return false; // Překrývá jinou loď
                }
            }
            else
            {
                if (x + length > array.GetLength(0)) return false; // Přesahuje hranice

                for (int i = 0; i < length; i++)
                {
                    if (array[x + i, y] != 0) return false; // Překrývá jinou loď
                }
            }

            return true;
        }

        // Funkce pro umístění lodi
        static void PlaceShip(int[,] array, int x, int y, int length, bool isHorizontal)
        {
            if (isHorizontal)
            {
                for (int j = 0; j < length; j++)
                {
                    array[x, y + j] = 3;
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    array[x + i, y] = 3;
                }
            }
        }
        //Funkce pro umístění několoka loďí
        static void Place3Ships(int[,] array, bool rot, int x, int y)
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                bool placed = false;

                while (!placed)
                {
                    rot = rnd.Next(0, 2) == 1; // Horizontální (true) nebo vertikální (false)
                    x = rnd.Next(0, 10);
                    y = rnd.Next(0, 10);


                    if (CanPlaceShip(array, x, y, 3, rot))
                    {
                        PlaceShip(array, x, y, 3, rot);



                        placed = true;
                    }
                }
            }
        }

        //Plošná kontrola stavu pole
        static bool CheckArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] == 3)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
        //Funkce umožňující střílet
        static void playerShoot(int[,] arrayPC,int [,]arrayShadow, string vertical, string horizontal, int col, int row)
        {

            while (true)
            {


                while (true)
                {
                    Console.WriteLine("Zvol si sloupec, střelíš(0-9)");
                    vertical = Console.ReadLine();
                    if (int.TryParse(vertical, out col))
                    {
                        break;
                    }
                    Console.WriteLine("vstup je chybně");

                }
                if (col > 9)
                {
                    Console.WriteLine("Přečti si znovu zadání");
                    continue;

                }
                while (true)
                {
                    Console.WriteLine("Zvol si řádek, kam střelíš(0-9)");
                    horizontal = Console.ReadLine();
                    if (int.TryParse(horizontal, out row))
                    {
                        break;
                    }
                    Console.WriteLine("vstup je chybně");

                }

                row = int.Parse(horizontal);
                if (row > 9)
                {
                    Console.WriteLine("Přečti si znovu zadání");
                    continue ;
                }


                if (arrayPC[col, row] == 3)
                {
                    arrayShadow[col, row] = 5;
                    arrayPC[col, row] = 5;
                    break;
                }
                else if (arrayPC[col, row] == 0)
                {
                    arrayShadow[col, row] = 6;
                    arrayPC[col, row] = 6;
                    break;

                }
                else if (arrayPC[col, row] == 5)
                {
                    Console.WriteLine("Zasáhl jsi zasaženou loď. Mamlasi");
                    break;
                }
                else if (arrayPC[col, row] == 6)
                {
                    Console.WriteLine("Tam už jsi střílel");
                    break;
                }

                Console.Clear();
                Console.WriteLine("Soupeřovo pole");
                DrawField(arrayShadow);

            }

            
        }
        //Funkce která střílí na hráče
        static void pcShoot(int[,]array, int x, int y)
        {
        checkpoint:
            Random random = new Random();
            x = random.Next(0, 10);
            y = random.Next(0, 10);
            if (array[x, y] == 3)
            {
                array[x, y] = 5;

            }
            else if (array[x, y] == 0)
            {
                array[x, y] = 6;
            }
            else if (array[x, y] == 5)
            {
                goto checkpoint;
            }
            else if (array[x, y] == 6)
            {
                goto checkpoint;
            }
        }

     

        static void Main(string[] args)
        {
            Console.WriteLine("VELKOLEPÁ HRA BITEVNÍCH LODÍ");
            Console.WriteLine("Toto je moře, na kterém se hra odehrává");
            int x = 0;
            int y = 0;
            bool rot = true;
            string vertical=("");
            int col=0;
            string horizontal=("");
            int row=0;
            Random rnd = new Random();
            int[,] array = new int[10, 10];
            int[,] arrayPC = new int[10, 10];
            int[,] arrayShadow = new int[10, 10];
            SetArrayToDefault(array, arrayPC, arrayShadow);
            DrawField(arrayPC);
            Console.ReadKey();
            Console.Clear();
            Place3Ships(array,rot,x,y);// Náhodné rozmístění mých lodí
            Thread.Sleep(600); // power napík            
            Place3Ships(arrayPC, rot, x, y);//náhodné rozmístění soupeřových lodí       
            Console.WriteLine("soupeřovo pole (nevidíš ho)");
            DrawField (arrayShadow);
            Console.WriteLine("Tvoje pole");
            DrawField(array);
            Console.ReadKey();
          

            // dokud jsou lodě bude se hrát
            while (CheckArray(arrayPC) == true ||CheckArray(array) == true)
            {
                playerShoot(arrayPC, arrayShadow, vertical, horizontal, col, row);
                pcShoot(array, x, y);
                Console.Clear();
                Console.WriteLine("soupeřovo pole (nevidíš ho)");
                DrawField(arrayShadow);
                Console.WriteLine("Tvoje pole");
                DrawField(array);

            }

            if (CheckArray(arrayPC) == true)
            {
                Console.WriteLine("Vyhrál jsi!");
            }
            else
            {
                Console.WriteLine("Prohrál jsi");
            }
                

            Console.ReadKey ();
            
            
            
        }
         
    }
}
