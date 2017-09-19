using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n");
            string userInput;
            double countNumber;
            Console.WriteLine("Input how many numbers to couont together?");
            userInput = Console.ReadLine();
            countNumber = double.Parse(userInput);

            if (countNumber >= 1)
            {
                double result = 0;
                for (int i = 0; i <= countNumber; i++)
                {
                    //result = result + (result + i);
                    result = result + i;
                }

                Console.WriteLine("Sum of {0} first numbers is {1} ", countNumber, result);
                Console.Write("\n Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Usersinput value {0} must be > 1:", userInput);
                Console.Write("\n Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
