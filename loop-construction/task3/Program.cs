﻿using System;

namespace task3
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
            countNumber = double.Parse(userInput);

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
            Console.WriteLine("Sum of {0} first numbers is {1} and sum of evens {2} and odds {3} ", countNumber, result, evenResult, oddResult);
            Console.Write("\n Press any key to continue...");
            Console.ReadKey();
        }
    }
}
