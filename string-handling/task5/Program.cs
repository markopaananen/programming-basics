
using System;
using System.Text.RegularExpressions;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.WriteLine("Let the randoom sentance here:");
            // Store user input into a variable
            string userInput = Console.ReadLine().ToString();
            // Create a new instance of the Regex class with a regular expression matching all the vowels
            Regex rx = new Regex(@"[AEIOUaeiou]");
            // Store matches between the user input and the regular expression
            MatchCollection matches = rx.Matches(userInput);
            // Print out the number of vowel occurrences in the user input 
            Console.WriteLine("\nYour sentance contains {0} vovels", matches.Count);
            // Wait for any key to be pressed before exiting
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}