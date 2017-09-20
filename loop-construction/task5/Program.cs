using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Sum given first even and odd numbers together\n");
            string userInput;
            double countNumber;
            Console.WriteLine("Input how many numbers to couont together?");
            userInput = Console.ReadLine();
            countNumber = Math.Abs(double.Parse(userInput));

            double evenResult = 0;
            double oddResult = 0;
            for (int i = 0; i <= countNumber; i++)
            {
                if (i % 2 == 0)
                {
                    evenResult = evenResult + i;
                }
                else
                {
                    oddResult = oddResult + i;
                }
            }
            double result = evenResult + oddResult;

            string evenLine = "Sum of {0} first numbers is {1} and sum of evens {2} and odds {3} ";
            string oddLine = "Sum of -{0} first numbers is -{1} and sum of evens -{2} and odds -{3} ";
            string writeLine = evenLine;
            if (int.Parse(userInput) < 0) writeLine = oddLine;
            
            Console.WriteLine(writeLine, countNumber, result, evenResult, oddResult);
            Console.Write("\n Press any key to continue...");
            Console.ReadKey();

            // Random 1 - 100
            Random rnd = new Random();
            for (int j = 0; j <= 100; j++)
            {
                rnd.NextDouble();
                Console.WriteLine("Random number {0} is: {1}", j, rnd.Next(100));
            }
            Console.Write("\n Press any key to continue...");
            Console.ReadKey();
        }
    }
}
