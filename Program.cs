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

            // Asks users name
            Console.WriteLine("What is your name?");

            // Get user input
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", input);

            // Init correct number
            int correctNumber = 7;

            // Init guess var
            int guess = 0;
        }
    }
}