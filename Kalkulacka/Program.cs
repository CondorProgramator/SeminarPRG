using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    internal class Program
    {

        static void Writenumber()
        {


        }
        static void Main(string[] args)
        {
            while (true)
            {
            
                
            try
            {
                int kontrolka = 0;
                int vysledek = 0;

                Console.WriteLine("Zadej prvni číslo");
                string prvni = Console.ReadLine();
                int prva = int.Parse(prvni);

                Console.WriteLine("Zadej druhe číslo");
                string druhy = Console.ReadLine();
                int druha = int.Parse(druhy);

                Console.WriteLine("Napis + nebo - nebo * nebo / ");
                string operace = Console.ReadLine();

                switch (operace)
                {
                    case "+":
                        vysledek = prva + druha;
                        kontrolka++;
                        break;

                    case "-":
                        vysledek = prva - druha;
                        kontrolka++;
                        break;

                    case "*":
                        vysledek = prva * druha;
                        kontrolka++;
                        break;

                    case "/":
                        vysledek = prva / druha;
                        kontrolka++;
                        break;


                    default:
                        
                        break;

                }

                Console.WriteLine($"vysledek je {vysledek} ");
            }
            catch (FormatException)
            {
                Console.WriteLine("neplatny input");                        
            }
            }
            Console.ReadKey();


        }
    }
}
