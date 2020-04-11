using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "leigh"; //set up secret word
            string guess = ""; //initialise guess variable
            int index = 0;

            do
            {
                Console.Write("Guess {0}: What's the secret word?", index+1); //ask for guess (add one because index initialised at 0)
                guess = Console.ReadLine(); //read it in to guess variable
                index++;
            }
            while (secretWord != guess && index < 5); //check if words match, if no loop again, if they do then break loop

            if (index <= 5 && guess == secretWord) //once loop broken, check if guessed correctly within 5 guesses
            {
                Console.WriteLine("Congratulations, you guessed it right on guess {0}!", index); //success message tells user which guess they got it on
            }
            else
            {
                Console.WriteLine("Sorry, you lose, you loser!");
            }
        }
    }
}
