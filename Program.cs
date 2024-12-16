using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Wlcome to the game!!!!!");
            Console.WriteLine("Can you guess the number between 1 and 100?");

            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            int guess = 0;

            while (guess != randomNumber)
            {
                Console.Write("Enter your guess: ");
                string userGuess = Console.ReadLine();
                

                // Try to convert the user input to an integer
                bool isValid = int.TryParse(userGuess, out guess);

                if (!isValid)
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;  // Skip the rest of the loop and ask for input again
                }


                if (guess < randomNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Too high!");
                } else
                {
                    Console.WriteLine("Correct!"); 
                }

            }


            Console.ReadLine();


        }
    }
}