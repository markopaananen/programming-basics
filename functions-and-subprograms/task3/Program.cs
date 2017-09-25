using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)

        {
            double userDefinedNumber = 0;
            double inputMinNumber = 4;
            double inputMaxNumber = 10;

            userDefinedNumber = AskForANumber(inputMinNumber, inputMaxNumber);
            Console.WriteLine("\nUser gives a number {0}", userDefinedNumber);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            double AskForANumber(double minNumber, double maxNumber)
            {
                double number = 0;
                Console.Write("Give a number between {0} and {1}: ", minNumber, maxNumber);
                string userInput = Console.ReadLine();
                while ((!double.TryParse(userInput, out number)) || (number < minNumber) || (number > maxNumber))
                {
                    // Prompt user for input
                    Console.Clear();
                    Console.WriteLine("Given number {0} is outside range {1} and {2}. New try. ", userInput, minNumber, maxNumber);
                    Console.Write("Give a number {0} and {1}: ", minNumber, maxNumber);
                    userInput = Console.ReadLine();
                }
                return number;
            }
        }
    }
}
