using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string hiddenWord = "Spiderman";
            string guess = "";

            while(guess != hiddenWord)
            {
                Console.WriteLine("Enter Guess: ");
                guess = Console.ReadLine();
            }
            Console.WriteLine("You Win!");

            Console.ReadLine();
        }
    }
}
