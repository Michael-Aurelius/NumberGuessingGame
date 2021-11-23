using System;

namespace NumberGuessingGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var r = new Random();

            var winNum = r.Next(0, 100);

            var win = false;

            do
            {
                Console.Write("Guess a number in-between 0 and 100:");
                var userInput = Console.ReadLine();
                int userGuess;
                while (!int.TryParse(userInput, out userGuess))
                {
                    Console.WriteLine("You did not enter a valid number, try again.");
                    userInput = Console.ReadLine();
                }

                if (userGuess > winNum)
                {
                    Console.WriteLine("Your guess was too high! Try again.");
                }
                else if (userGuess < winNum)
                {
                    Console.WriteLine("Your guess was too low! Try again.");
                }
                else if (userGuess == winNum)
                {
                    Console.WriteLine("You Win!!!");
                    win = true;
                }

                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("Thank you for playing the game!");
            Console.Write("Press any key to finish.");
            Console.ReadKey(true);
        }
    }
}