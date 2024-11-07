using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti libovolnými čísly.

            int[] field = {1,2,3,4,5};

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus jak klasický for, kde i využiješ jako index v poli, tak foreach.
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(field[i]);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + field[i];
            }
            Console.WriteLine("součet prvků je "+sum);


            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average;
            int suma = 0;
            for (int i = 0; i < field.Length; i++)
            {
                suma = suma + field[i];
            }
            average = suma / field.Length;
            Console.WriteLine("průměr prvků je "+average);


            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max;
            max = field.Max();    
            Console.WriteLine("maximum v poli je "+max);


            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min;
            min = field.Min();
            Console.WriteLine("minimum v poli je "+min);


            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.

            int index=666;
            try
            {               
                Console.WriteLine("a teď napiš číslo mezi 0 a "+field.Length);
                string input = Console.ReadLine();
                index = int.Parse(input);            
            }
            catch (FormatException)

            {
                Console.WriteLine("neplaty input");
            }
            if (index <= field.Length)
            {
                Console.WriteLine("na pořadí číslo "+index+" je hodnota "+field[index]);
            }else
            {
                Console.WriteLine("napsal jsi moc velký index");
            }


                //TODO 8: Přepiš pole na úplně nové tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9.


                Random rng = new Random();
                int[] array = new int[100];

                for (int i = 0; i < 100; i++)
                {
                    array[i] = rng.Next(0,10);               
                }   
            Console.WriteLine("počet členů je "+array.Length+" a třicátý člen je " + array[30] );
            

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            switch (switch_on)
            {
                case
                default:
            }




            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.


            //Zkus is dál hrát s polem dle své libosti. Můžeš třeba prohodit dva prvky, ukládat do pole prvky nějaké posloupnosti (a pak si je vyhledávat) nebo cokoliv dalšího tě napadne

            Console.ReadKey();
        }
    }
}
