namespace guessNumberGame
{
    internal class Program
    {
        public const int GUESS_LIMIT = 5;
        static void Main(string[] args)
        {
            Random nmb = new Random();

            while (true)
            {
                // Initialize guess counter to 0
                int guessCounter = 0;

                // Chosing a random number
                int randomNumber = nmb.Next(1, 101);

                while (true)
                {
                    // Checking if the user has made 5 guesses
                    if (guessCounter == GUESS_LIMIT)
                    {
                        Console.WriteLine("You have reached the maximum number of guesses.\nYou lose");
                        break;
                    }

                    // Showing the number of remaining guesses
                    int remainingGuesses = GUESS_LIMIT - guessCounter;
                    Console.WriteLine($"You have {remainingGuesses} guesses remaining");

                    // Asking the user to guess the number 
                    Console.Write("Please guess a number between 1 and 100: ");
                    string userInput = Console.ReadLine();
                    int numberGuess = Convert.ToInt32(userInput);

                    // Using  if statements to check if the numbers are to high, to low or the same 
                    if (numberGuess > randomNumber)
                    {
                        Console.WriteLine("The number you choose is too high, try again");
                    }
                    if (numberGuess < randomNumber)
                    {
                        Console.WriteLine("The number you choose is too low, try again");
                    }
                    // Checking if the guess is within 5 of the random number
                     if (Math.Abs(numberGuess - randomNumber) <= 5)
                    {
                        Console.WriteLine("You're close!");
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
