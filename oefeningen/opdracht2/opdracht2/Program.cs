using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;

namespace Boodschappen
{
    class Program
    {
        static void Main(string[] args)
        {
            float totaalprijs = 0f;           
            List<Item> ItemList = new List<Item>();
            ItemList.Add(new Item("Kaas", 2f, 1.21f));
            ItemList.Add(new Item("Brood", 1.5f, 1.21f));
            ItemList.Add(new Item("Ham", 1f, 1.21f));
            ItemList.Add(new Item("Komkomer",1.5f,1.21f));
            ItemList.Add(new Item("Tomaten",1.5f,1.21f));
            ItemList.Add(new Item("Koek",2f,121f));
            ItemList.Add(new Item("Pasta",1.5f,1.21f));
            ItemList.Add(new Item("Water",1f,1.21f));
            ItemList.Add(new Item("Mayonaise",1.5f,1.21f));
            ItemList.Add(new Item("Ketchup",1.5f,1.21f));
            Item Item1 = new Item("", 2f, 1.21f);
            

            foreach (var Item in ItemList)
            {
                Console.WriteLine(Item.naam + " " +Item.prijs + " euro");
            }
            for (int j = 0; j <= 2; j++)
            {
                
                Console.WriteLine("Kies een product");
                string p = Console.ReadLine();
                
                bool IsCorrect = false;
                foreach (Item Key in ItemList)
                {
                    if (Key.naam == p)
                    {
                        IsCorrect = true;                        
                        Item1 = Key;                                              
                    }
                }                
                    if (IsCorrect = false)
                    {
                        Console.WriteLine("Dat kan helaas niet");
                    }
                    else
                    {
                        Console.WriteLine("Hoeveel wil je er?");
                        int aBoodschappen = Convert.ToInt32(Console.ReadLine());
                        float totaalp = (aBoodschappen * Item1.prijs) * Item1.Btw;
                        totaalprijs += totaalp;
                    }                
            }
            Console.WriteLine(totaalprijs);
        }
    }
}

/*double prijs = 0.00;
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
*/



