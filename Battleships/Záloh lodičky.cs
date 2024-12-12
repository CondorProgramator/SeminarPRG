using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    internal class Program
    {



        static void DrawField(int[,] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToPrint.GetLength(1); j++)
                {
                    // Vyměním symbol 3 čtverečkem
                    if (arrayToPrint[i, j] == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("(3)"); 
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (arrayToPrint[i, j] == 2)
                    { 
                        Console.Write("(L)"); // udělám si pole
                    }
                    if (arrayToPrint[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("[ ]");
                        Console.ForegroundColor= ConsoleColor.White;
                    }
                        
                }
                Console.WriteLine();
            }
        }

        static void SetArraytoDefault(int[,] arrayToSet, int[,] arrayPC)
    {
        for (int i = 0; i < arrayToSet.GetLength(0); i++)
        {
            for (int j = 0; j < arrayToSet.GetLength(1); j++)
            {
                arrayToSet[i, j] = 0;
                arrayPC[i, j] = 0;
            }
        }
    }


        static void ChoseShip(int[,] arrayToShip)
        {
        checkpoint:

            Console.WriteLine("Zvol si řádek, kam si dáš loď 3*1 (0-8)");
            string column = Console.ReadLine();
            int vertical = int.Parse(column);

            Console.WriteLine("Zvol si sloupec, kam dáš svou loď 3*1 (0-8)");
            string row = Console.ReadLine();
            int horizontal = int.Parse(row);



            Console.WriteLine("vertikálně, nebo horizontálně? (v/h)");
            string rot = Console.ReadLine().ToLower();

            // Automatická úprava souřadnic, aby se loď vešla do pole
            if (rot == "v")
            {
                // Pokud loď přesahuje dolní hranici
                if (vertical + 2 >= arrayToShip.GetLength(0))
                {
                    vertical = arrayToShip.GetLength(0) - 3;
                }
            }
            else if (rot == "h")
            {
                // Pokud loď přesahuje pravou hranici
                if (horizontal + 2 >= arrayToShip.GetLength(1))
                {
                    horizontal = arrayToShip.GetLength(1) - 3;
                }
            }
            else
            {
                Console.WriteLine("Neplatný vstup, zkus to znovu.");
                goto checkpoint;
            }

            // Kontrola, zda je zvolený prostor volný
            for (int i = 0; i < 3; i++)
            {
                if (rot == "v" && arrayToShip[vertical + i, horizontal] != 0)
                {
                    Console.WriteLine("Tato oblast už obsahuje loď. Zkus jiné místo.");
                    goto checkpoint;
                }
                else if (rot == "h" && arrayToShip[vertical, horizontal + i] != 0)
                {
                    Console.WriteLine("Tato oblast už obsahuje loď. Zkus jiné místo.");
                    goto checkpoint;
                }
            }

            // Umístění lodi
            switch (rot)
            {
                case "v":
                    for (int i = 0; i < 3; i++)
                    {
                        arrayToShip[vertical + i, horizontal] = 3;
                    }
                    break;

                case "h":
                    for (int i = 0; i < 3; i++)
                    {
                        arrayToShip[vertical, horizontal + i] = 3;
                    }
                    break;

                default:
                    Console.WriteLine("Neplatný vstup, zkus to znovu.");
                    goto checkpoint;
            }
        }

        static void ChoseLShip(int[,] arrayToShip) // výběr L lodě
        {
        checkpoint:

            Console.WriteLine("Zvol si řádek, kam si dáš střed lodě ve tvaru L (0-8)");
            string column = Console.ReadLine();
            int vertical = int.Parse(column);

            Console.WriteLine("Zvol si sloupec, kam dáš střed lodě ve tvaru L(0-8)");
            string row = Console.ReadLine();
            int horizontal = int.Parse(row);



            Console.WriteLine("vertikálně, nebo horizontálně? (v/h)");
            string rot = Console.ReadLine().ToLower();

            // Automatická úprava souřadnic, aby se loď vešla do pole
            if (rot == "v")
            {
                // Pokud loď přesahuje dolní hranici
                if (vertical + 2 >= arrayToShip.GetLength(0))
                {
                    vertical = arrayToShip.GetLength(0) - 3;
                }
            }
            else if (rot == "h")
            {
                // Pokud loď přesahuje pravou hranici
                if (vertical - 2 >= arrayToShip.GetLength(1))
                {
                    vertical = arrayToShip.GetLength(1) - 3;
                }
            }
            else
            {
                Console.WriteLine("Neplatný vstup, zkus to znovu.");
                goto checkpoint;
            }

            // Kontrola, zda je zvolený prostor volný
            for (int i = 0; i < 3; i++)
            {
                if (rot == "v" && arrayToShip[vertical + i, horizontal] != 0)
                {
                    Console.WriteLine("Tato oblast už obsahuje loď. Zkus jiné místo.");
                    goto checkpoint;
                }
                else if (rot == "h" && arrayToShip[vertical, horizontal + i] != 0)
                {
                    Console.WriteLine("Tato oblast už obsahuje loď. Zkus jiné místo.");
                    goto checkpoint;
                }
            }

            // Umístění lodi
            switch (rot)
            {
                case "v":
                    for (int i = 0; i < 3; i++)
                    {
                        arrayToShip[vertical + i, horizontal] = 2;
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        arrayToShip[vertical, horizontal + j] = 2;
                    }
                    
                    break;

                case "h":
                    for (int i = 0; i < 3; i++)
                    {
                        arrayToShip[vertical, horizontal + i] = 2;
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        arrayToShip[vertical + j, horizontal] = 2;
                    }
                    break;

                default:
                    Console.WriteLine("Neplatný vstup, zkus to znovu.");
                    goto checkpoint;
            }
        }



        static void Main(string[] args)
            {           
            Random rnd = new Random();   
            int[,] array = new int[10,10];
            int[,] pcArray = new int[10,10];
            SetArraytoDefault(array, pcArray); // založení pole
            DrawField(array);// nakreslení pole
            //ChoseLShip(array);
            //DrawField(array);
            ChoseShip(array); // vybrání lodě        
            DrawField(array);// nakreslení pole s lodí
            ChoseShip(array); // vybrání lodě        
            DrawField(array);// nakreslení pole s lodí


            while (true)
            {
                int rot = rnd.Next(0,2);
                int x = rnd.Next(0,9);
                int y = rnd.Next(0,9);
            }
            
                       



            Console.ReadKey();

            }
        
        
        }
    }
