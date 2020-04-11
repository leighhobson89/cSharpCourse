using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "leigh"; //set up secret word
            string guess = ""; //initialise guess variable
            int index = 1;

            do
            {
                Console.Write("Guess " + index + ": What's the secret word?"); //ask for guess
                guess = Console.ReadLine(); //read it in to guess variable
                index++;
            }
            while (secretWord != guess && index < 6); //check if words match, if no loop again, if they do then break loop

            if (index <= 6 && guess == secretWord) //once loop broken, check if guessed correctly within 5 guesses (use 6 as index variable initialised at 1)
            {
                Console.WriteLine("Congratulations, you guessed it right on guess {0}!", index-1); //success message tells user which guess they got it on, minus one because variable initialised at 1
            }
            else
            {
                Console.WriteLine("Sorry, you lose, you loser!");
            }
        }
    }
}
