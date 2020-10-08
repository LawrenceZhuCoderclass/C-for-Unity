using System;

namespace Te
{
    class Program
    {
        static void Main(string[] args)
        {
            float incl;
            float korting;
            float verzend;
            Tele Tele1 = new Tele("iPhone", "iPhone XS", "Apple IOS", "Steve Jobs", 600f);
            Tele Tele2 = new Tele("Samsung", "Galaxy S7", "Ändroid","Kim-Hyun-chull", 299f);
            Tele Tele3 = new Tele("Google Pixel", "Pixel 3", "Chrome OS", "Sundar Pichai", 399f);

            Tele[] Teles = new Tele[3];
            Teles[0] = Tele1;
            Teles[1] = Tele2;
            Teles[2] = Tele3;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Teles[i].Type + " " + Teles[i].CEO);
            }
            
            Console.WriteLine("Hoeveel iPhone XS wil je");
            int aantal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel Galaxy's S7 wil je?");
            int aantal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel pixel3's wil je?");
            int aantal3 = Convert.ToInt32(Console.ReadLine());
            
            float totaalPrijsIphone = Tele1.BTW(aantal1);
            float totaalPrijsSamsung = Tele2.BTW(aantal2);
            float totaalPrijsPixel = Tele3.BTW(aantal3);
            
            incl = totaalPrijsIphone + totaalPrijsPixel + totaalPrijsSamsung;
            verzend = incl * 0.1f;
            korting = incl * 0.2f;
            if (incl >= 1000f)
            {
                incl = incl - korting;
                Console.WriteLine("U krijgt " + korting + " euro korting");
            }
            Console.WriteLine("Alles in totaal kost " + incl + " euro");
            Console.WriteLine("Verzendkosten zijn" + verzend + " euro");
            }
            

                   


        }

    }

