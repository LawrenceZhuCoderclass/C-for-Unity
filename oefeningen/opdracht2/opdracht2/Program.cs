using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Boodschappen
{
    class Program
    {
        static void Main(string[] args)
        {
            double prijs = 0.00;
            double BTW = 1.21;
            IDictionary<string, double> items = new Dictionary<string, double>();
            items.Add("Kaas", 1.50);
            items.Add("Melk", 1.00);
            items.Add("Komkomer",1.50);
            items.Add("Tomaten",1.50);
            items.Add("Koek",2.00);
            items.Add("Fanta",1.50);
            items.Add("Pasta",2.00);
            items.Add("Eieren",3.00);
            items.Add("Yoghurt",2.00);
            items.Add("Water",0.50);

            foreach (KeyValuePair<string, double> ele in items)
            { 
                Console.WriteLine("Product = {0}, Prijs = {1}", ele.Key, ele.Value);
            }
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Kies een product");
                string p = Console.ReadLine();

                bool IsCorrect = false;
                foreach (KeyValuePair<string, double> key in items)
                {
                    if (key.Key == p)
                    {
                        IsCorrect = true;
                    }
                }
                if (!IsCorrect)
                {
                    Console.WriteLine("Dat helaas niet");
                }
                else
                {
                    Console.WriteLine("Hoeveel wil je er");
                    int aBoodschappen = Int32.Parse(Console.ReadLine());
                    prijs += items[p] * aBoodschappen;  
                }
            }
            Console.WriteLine("Dat kost zonder BTW " + prijs + " euro");
            Console.WriteLine("Inclusief BTW kost het " + prijs * BTW + " euro");

        }
    }
}
