using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            Console.WriteLine("wat is het eerste getal");
            int getal1 =  Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("wat is het tweede geetal");
            int getal2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Kies je operator: +, -, / ,* ");
            string op = Convert.ToString(Console.ReadLine());
            switch(op)
            {
                case "+":
                    result = getal1 + getal2;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = getal1 - getal2;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = getal1* getal2;
                    Console.WriteLine(result);
                    break;
                case "/":
                    if (getal2 == 0)
                    {
                        Console.WriteLine("Kan niet delen door 0");
                    }
                    result = getal1 / getal2;
                    Console.WriteLine(result);
                    break;
            }
            /*if (operator == "+")
            {
                result = getal1 + getal2;
                Console.WriteLine(result);
            }
            else if (operator == "-")
            {
                result = getal1 - getal2;
                Console.WriteLine(result);
            }
            else if(operator == "*")
            {
                result = getal1 * getal2;
                Console.WriteLine(result);
            }
            else if(operator == "/")
            {
                if (getal2 == 0)
                {
                    Console.WriteLine("Kan niet delen door 0");
                }
                else
                {
                    
                    Console.WriteLine(getal1 / getal2);
                }
            }
            else
            {
                Console.WriteLine("niet geldige input");
            }
            */
                


        }
    }
}
