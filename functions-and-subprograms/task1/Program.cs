using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.Write("How many stars to prompt on display? ");
            // Store user input to a variable
            string userInput = Console.ReadLine();
            // Parse user input into integer
            int.TryParse(userInput, out int starNumber);
            // If user input is a positive integer...
            if (starNumber > 0)
            {
                // Call the function NumberOfStars with the user input as a parameter
                Console.WriteLine("Here are the stars: {0}", CreateStars(starNumber));
            }
            else
            {
                // Print out an error message
                Console.WriteLine("Number {0} is not allowed", starNumber);
            }
            // Wait for any key to be pressed before exiting
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            // ******************
            // the first function
            // ******************
            string CreateStars(int starsAsNumber)
            {
                // Declare a string to hold the stars
                string strStars = "";
                // Loop through the times indicated by the user input
                for (int i = 1; i <= starsAsNumber; i++)
                {
                    // Add a star to the string
                    strStars = strStars + "*";
                }
                // Return the star string
                return strStars;
            }
        }
    }
}
