

namespace guessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random nmb = new Random();

            while (true)
            {
                // Chosing a random number     
                int randomNumber = nmb.Next(1, 101);

                int tryCounter = GuessNumberMethods.Counter();
                int tryLimit = GuessNumberMethods.Limit();

                while (true)
                {
                    // Checking if the user has made 5 guesses
                    if (tryCounter == tryLimit)
                    {
                        GuessNumberMethods.YouLose();
                        break;
                    }

                    // Showing the number of remaining guesses
                    int remainingGuesses = tryLimit - tryCounter;
                    GuessNumberMethods.RemainingGuesses(remainingGuesses);

                    // Asking the user to guess the number 
                    int numberGuess = GuessNumberMethods.UserInput();

                    // Using  if statements to check if the numbers are to high, to low or the same 
                    if (numberGuess > randomNumber)
                    {
                        GuessNumberMethods.ToHigh();
                    }
                    if (numberGuess < randomNumber)
                    {
                        GuessNumberMethods.ToLow();
                    }

                    // Checking if the guess is within 5 of the random number
                    if (Math.Abs(numberGuess - randomNumber) <= 5)
                    {
                        GuessNumberMethods.Almost();
                    }
                    if (numberGuess == randomNumber)
                    {
                        GuessNumberMethods.Win();
                        break;
                    }

                    // Increment the guess counter
                    tryCounter++;
                }
            }
        }
    }
}