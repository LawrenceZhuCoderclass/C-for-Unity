using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nummers = new int[21];
            int n1 = 0;
            int n2 = 1;
            int n3;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
                

            for (int i = 0; i < 21; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1= n2;
                n2= n3;
            }
        }
    }
}
