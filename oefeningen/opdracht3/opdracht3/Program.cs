using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("wat is het eerste getal");
            int getal1 =  Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("wat is het tweede geetal");
            int getal2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Kies je operator: +, -, / ,* ");
            string op = Convert.ToString(Console.ReadLine());

            if (op == "+")
            {
                result = getal1 + getal2;
                Console.WriteLine(result);
            }
            else if (op == "-")
            {
                result = getal1 - getal2;
                Console.WriteLine(result);
            }
            else if(op == "*")
            {
                result = getal1 * getal2;
                Console.WriteLine(result);
            }
            else if(op == "/")
            {
                if (getal2 == 0)
                {
                    Console.WriteLine("Kan niet delen door 0");
                }
                else
                {
                    result = getal1 / getal2;
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("niet geldige input");
            }
                


        }
    }
}
