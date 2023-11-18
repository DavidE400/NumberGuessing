using System;
using System.ComponentModel;

// Namespace
namespace NumberGuesser
{
    // Main class
    internal class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to fetch info
            GetGreetingInfo(); // Run GetGreetingInfo function to fetch info

            while (true)
            {
                // Create a new Random object
                Random random = new Random();
                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10?");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure user inputs number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message 
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        
                        // Keep going 
                        continue;
                    }

                    // Cast to int and put it in guess var(Use Int32 to parse str to int)
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number please try again");
                    }
                }

                // Output success message
                if (guess == correctNumber)
                {
                    // Print success message
                    PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");

                    // Ask the user if they want to play again
                    Console.WriteLine("Do you want to play again? [Y or N]");

                    // Get answer
                    string answer = Console.ReadLine().ToUpper();

                    if(answer == "Y")
                    {
                        continue;
                    }
                    else if(answer == "N")
                    {
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        static void GetAppInfo(){
            // SET app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "David Estrada";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        static void GetGreetingInfo(){
            // Asks users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message 
        static void PrintColorMessage(ConsoleColor color, string message){
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}