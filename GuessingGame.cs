using System;

namespace Guessing_Game
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            string hiddenWord = "Spiderman";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outofGuess = false;

            while(guess != hiddenWord && !outofGuess)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter Guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }else
                {
                    outofGuess = true; //Flags, this is telling us a peice of info
                }
                
            } if (outofGuess)
            {
                Console.WriteLine("You Lose!");

            }
            else
            {
                Console.WriteLine("You Win!");
            }
            Console.ReadLine();
        }
    }
}
