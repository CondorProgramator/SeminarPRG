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
         
            int vysledek = 0;
            Console.WriteLine("Zadej prvni číslo");
            string prvni = Console.ReadLine();
            int prva = int.Parse(prvni);            

            Console.WriteLine("Zadej druhe číslo");
            string druhy = Console.ReadLine();
            int druha = int.Parse(druhy);

            Console.WriteLine("Napis soucet nebo rozdil nebo krat");
            string operace = Console.ReadLine();r

            switch (operace)
            {
                case "soucet":
                    vysledek = prva + druha;
                    break;
                case "rozdil":
                    vysledek = prva - druha;
                    break;
                case "nasobek":
                    vysledek = prva * druha;
                    break;

                

                default:
                    break;
            }
           


            if (operace == "soucet") 
            {
                 vysledek = prva + druha;
            }
            if (operace == "rozdil")
            {
                 vysledek = prva - druha;
            }
            if (operace == "krat")
            {
                vysledek = prva * druha;
            }
            else
            {
                Console.WriteLine("neplatny input");
            }
                Console.WriteLine ($"vysledek je {vysledek} ");



            Console.ReadKey();


        }
    }
}
