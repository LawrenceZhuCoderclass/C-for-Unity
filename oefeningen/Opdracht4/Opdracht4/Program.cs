using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "informatica";
            string guessedWord = "";

            for (int aantal  = 0; aantal <=2; aantal++)
            {
                if (guessedWord != secretWord)
                {
                    Console.Write("Enter guess: ");
                    guessedWord = Console.ReadLine();

                }
                if (aantal == 0)
                {
                    Console.WriteLine("Het begint met i");
                }
                if (aantal == 1)
                {
                    Console.WriteLine("Het begint met in");
                }
                if(guessedWord == secretWord)
                {
                    Console.WriteLine("You've won");
                    break;
                
                }
               

            }
            
        }
    }
}