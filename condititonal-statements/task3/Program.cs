using System;

namespace task3
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

            // even case

            if ((evaluteNumber % 2) == 0 && evaluteNumber > 0) 
            {
                Console.WriteLine("Number {0} is even and positive", evaluteNumber);
            }
            else if ((evaluteNumber % 2) == 0 && evaluteNumber < 0)
            {
                Console.WriteLine("Number {0} is even and negative", evaluteNumber);
            }

            // odd case

            if ((evaluteNumber % 2) == 1 && evaluteNumber > 0)
            {
                Console.WriteLine("Number {0} is odd and positive", evaluteNumber);
            }
            else if ((evaluteNumber % 2) == -1 && evaluteNumber < 0)
            {
                Console.WriteLine("Number {0} is odd and negative", evaluteNumber);
            }
            else if (evaluteNumber == 0)
            {
                Console.WriteLine("Number {0} is zero and positive", evaluteNumber);
            }


            // wait
            Console.ReadKey();

        }
    }
}
