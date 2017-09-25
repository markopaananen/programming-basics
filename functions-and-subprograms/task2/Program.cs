using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.Write("Get Random number (use dot to separate desimals): ");
            string userInput = Console.ReadLine();
            double.TryParse(userInput, out double inputnumber1);
            Console.Write("Get another random number: ");
            userInput = Console.ReadLine();
            double.TryParse(userInput, out double inputnumber2);
            Console.WriteLine("Given number {0} was lesser.\n", MinNumber(inputnumber1, inputnumber2));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            double MinNumber(double number1, double number2)
            {
                // Return the lesser number
                return Math.Min(number1, number2);
            }
        }
    }
}
