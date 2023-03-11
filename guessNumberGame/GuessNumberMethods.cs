
namespace guessNumberGame
{
    public static class GuessNumberMethods
    {
        public static int guessLimit = 5;
        public static int guessCounter = 0;
        /// <summary>
        /// Return the initial number of guesses 
        /// </summary>
        /// <returns></returns>
        public static int Limit()
        {
            int limit = guessLimit;
            return limit;
        }
        /// <summary>
        /// Returns the initial number of tries
        /// </summary>
        /// <returns></returns>
        public static int Counter()
        {
            int counter = guessCounter;
            return counter;
        }
        /// <summary>
        /// Prompting that the maximum number of guesses has been reached
        /// </summary>
        public static void YouLose()
        {
            Console.WriteLine("You have reached the maximum number of guesses.\nYou lose");
        }
        /// <summary>
        /// Prompting the number of guesses left
        /// </summary>
        /// <param name="result"></param>
        public static void RemainingGuesses(int result)
        {
            Console.WriteLine($"You have {result} guesses remaining");
        }
        /// <summary>
        /// Ask for a user input
        /// </summary>
        /// <returns></returns>
        public static int UserInput()
        {
            Console.Write("Please guess a number between 1 and 100: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }
        /// <summary>
        /// Prompt if the number choosen is to slow
        /// </summary>
        public static void ToLow()
        {
            Console.WriteLine("The number you choose is too low, try again");
        }
        /// <summary>
        /// Prompt if the number choosen is to high
        /// </summary>
        public static void ToHigh()
        {
            Console.WriteLine("The number you choose is too high, try again");
        }
        /// <summary>
        /// Prompt if the number choosen is within the range of 5 numbers from the random number
        /// </summary>
        public static void Almost()
        {
            Console.WriteLine("You're close!");
        }
        /// <summary>
        /// Prompt if the number choosen is the same like the random number
        /// </summary>
        public static void Win()
        {
            Console.WriteLine("Congratulation you won!!! Lets try again");
        }
    }
}
