using System;

namespace Boodschappen
{
    class Program
    {
        static void Main(string[] args)
        {
            int aantal;
            string p1 = "";
            const float prijsBrood = 1.00f;
            const float prijsKaas =  1.50f;
            const float prijsHam = 1.50f;
            const float prijsKoek = 2.50f;
            const float prijsSnoep = 2.00f;
            const float prijsMelk = 1.00f;
            const float prijsHagelslag = 2.00f;
            const float prijsPasta = 1.00f;
            const float prijsTomaten = 1.50f;
            const float prijsWijn = 15.00f;
            const float BtwPercentage = 1.21f;

            Console.WriteLine(@"brood = 1.00 
Kaas = 1.50
Ham = 1.50
Koek = 2.50
Snoep = 2.00
Melk = 1.00
Hagelslag = 2.00
Pasta = 1.00
Tomaten = 1.50
Wijn = 15.00
kies 3 producten");

            p1 = Console.ReadLine();


        }
    }
}
