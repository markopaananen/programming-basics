﻿using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.Write("How old are you (1-99): ");

            // Store user input to a variable
            string userInput1 = Console.ReadLine().ToString();

            // Declare variables

            double discountPercent = 0;
            double discountPercent2 = 0;
            double initialPrice = 16;
            double price;
            int mtkFlag = 0;

            // Parse user input into integer. If user 
            int.TryParse(userInput1, out int age);
            Console.Write("\n Your are {0} years old\n", age);

            // If age is under 7 years...
            if (age < 7)
            {
                // ...set the discount percentage to 100 % and move on to price calculation
                discountPercent = 1;

            }
            else if (age < 16 | age > 64)
            {
                // Else if age is between 7 and 15 or over 64, set the discount percentage to 50 % and move on to price calculation
                discountPercent = 0.5;
            }
            else
            {
                // Else if age is between 16 and 64...
                // Prompt user for input (k/e)
                Console.Write("\n Are you member of MTK (y/n)? ");

                // Store user input to a variable
                var userInput = Console.ReadKey();

                // If user input indicated that they are an MTK member...
                if (userInput.Key == ConsoleKey.Y)
                {
                    // ...set the discount percentage to 45 % and raise a flag for calculating a combined discount percentage with MTK membership
                    discountPercent = 0.15;
                    mtkFlag = 1;
                }

                // Prompt user for input (k/e)
                Console.Write("\n Are you student (Y/N)? ");

                // Store user input to a variable
                userInput = Console.ReadKey();

                // If user input indicated that they are a student...
                if (userInput.Key == ConsoleKey.Y)

                {
                    // ...and an MTK member
                    if (mtkFlag == 1)
                    {
                        // ...set the first discount percentage to 45 % and the second discount percentage to 15 %
                        discountPercent = 0.45;
                        discountPercent2 = 0.15;
                    }
                    else
                    {
                        // ...set the discount percentage to 45 %
                        discountPercent = 0.45;
                    }
                }

                // Prompt user for input (k/e)
                Console.Write("\n Are you an soldier (Y/N)? ");
                // Store user input to a variable
                userInput = Console.ReadKey();

                // If user input indicated that they are enlisted for army...
                if (userInput.Key == ConsoleKey.Y)
                {
                    // ...set the discount percentage to 50 % and clear the second discount percentage
                    discountPercent = 0.50;
                    discountPercent2 = 0;
                }
            }

            // Calculate the price after the first discount percentage
            price = initialPrice - (initialPrice * discountPercent);

            // Calculate the price after the second discount percentage
            price = price - (price * discountPercent2);

            // Inform the user of the price
            Console.WriteLine("\n\n Your ticket price is {0} euros", price);



            // Wait for any key to be pressed before exiting

            Console.WriteLine("\n Press any key to continue...");

            Console.ReadKey();

        }

    }

}