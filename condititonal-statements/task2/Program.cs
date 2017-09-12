using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // get value
            Console.WriteLine("Please enter one number!");

            // read uservalue variable
            string uservalue;
            uservalue = Console.ReadLine();

            // Evaluate value
            int evaluteNumber;
            evaluteNumber = int.Parse(uservalue);

            // % 2 true or false
            
            if((evaluteNumber % 2) == 0) 
            {
                Console.WriteLine("Number {0} is even", evaluteNumber);
            }
            else if ((evaluteNumber % 2) == 1) 
            {
                Console.WriteLine("Number {0} is odd 0", evaluteNumber);
            }

            // wait
            Console.ReadKey();

        }
    }
}
