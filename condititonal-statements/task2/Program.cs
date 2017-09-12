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

            // compare value
                        // if > 0
            if(evaluteNumber > 0)
            {
                Console.WriteLine("Number [0] greater than 0", evaluteNumber );
            }
            // if < 0
            if (evaluteNumber < 0)
            {
                Console.WriteLine("Number [0] less than 0", evaluteNumber);
            }

            // if == 0
            else
             {
                Console.WriteLine("Number [0] equal than 0", evaluteNumber);
            }

            // wait
            Console.ReadKey();

        }
    }
}
