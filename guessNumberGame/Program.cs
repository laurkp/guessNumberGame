using System.Drawing;
using System;
using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;

namespace guessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool restartGame = true;

            while (restartGame)
            {
                bool startAgain = true;

                // Initialize guess counter to 0
                int guessCounter = 0;

                // Chosing a random number 
                int randomNumber = new Random().Next(1, 101);
                Console.WriteLine(randomNumber);

                while (startAgain)
                {
                    // Checking if the user has made 5 guesses
                    if (guessCounter == 5)
                    {
                        Console.WriteLine("You have reached the maximum number of guesses.\nYou lose");
                        break;
                    }

                    // Asking the user to guess the number 
                    Console.Write("Please guess a number between 1 and 100: ");
                    string userInput = Console.ReadLine();
                    int numberGuess = Convert.ToInt32(userInput);

                    // Using  if statements to check if the numbers are to high, to low or the same 
                    if (numberGuess > randomNumber)
                    {
                        // Checking if the guess is within 5 of the random number
                        if (numberGuess - randomNumber <= 5)
                        {
                            Console.WriteLine("You're close!");
                        }
                        Console.WriteLine("The number you choose is too high, try again");
                    }
                    if (numberGuess < randomNumber)
                    {
                        if (numberGuess - randomNumber <= 5)
                        {
                            Console.WriteLine("You're close!");
                        }
                        Console.WriteLine("The number you choose is too low, try again");
                    }
                    if (numberGuess == randomNumber)
                    {
                        Console.WriteLine("Congratulation you won!!! Lets try again");
                        break;
                    }

                    // Increment the guess counter
                    guessCounter++;
                }
            }
        }
    }
}