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
                        Console.Write("■ "); 
                    }
                    else
                    {
                        Console.Write(". "); // udělám si pole
                    }
                }
                Console.WriteLine();
            }
        }

        static void SetArraytoDefault(int[,] arrayToSet)
    {
        for (int i = 0; i < arrayToSet.GetLength(0); i++)
        {
            for (int j = 0; j < arrayToSet.GetLength(1); j++)
            {
                arrayToSet[i, j] = 0;
            }
        }
    }

    static void ChoseShip(int[,] arrayToShip)
    {
        Console.WriteLine("Zvol si řádek, kam si dáš loď");
        string column = Console.ReadLine();
        int vertical = int.Parse(column);
        if (vertical > 9) { return; }

        Console.WriteLine("Zvol si sloupec, kam dáš svou loď");
        string row = Console.ReadLine();
        int horizontal = int.Parse(row);
        if (horizontal > 9) { return; }
        
        Console.WriteLine("vertikálně, nebo horizontálně? (v/h)");
        string rot = Console.ReadLine().ToLower();

            // KONTROLA, JESTLI SE LOĎ VEJDE DO POLE // 
            if (rot == "v" && vertical + 2 >= arrayToShip.GetLength(0))
            {
                Console.WriteLine("Tvoje loď sahá mimo pole");
                Console.ReadKey();
                return;
            }

            if (rot == "h" && horizontal + 2 >= arrayToShip.GetLength(1))
            {
                Console.WriteLine("Tvoje loď sahá mimo pole");
                Console.ReadKey();
                return;
            }

            // UMÍSTĚNÍ LODÍ
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

                break; //System.IndexOutOfRangeException
                default:
                Console.WriteLine("hodně neplatný input");
                return;
                
        }
    }

            static void Main(string[] args)
            {           
            int[,] array = new int[8,8];
            SetArraytoDefault(array); // založení pole
            DrawField(array); // nakreslení pole
            ChoseShip(array); // vybrání lodě        
            DrawField(array);// nakreslení pole s lodí
            ChoseShip(array);
            DrawField(array);    
            Console.ReadKey();

            }
        
        
        }
    }
