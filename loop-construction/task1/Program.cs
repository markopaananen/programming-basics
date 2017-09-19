using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n");
            double fractorNumber;
            string userInput;
            

            Console.WriteLine("Input fractorialnumeber ?");
            userInput = Console.ReadLine();
            fractorNumber = double.Parse(userInput);
            
            if (fractorNumber >= 0)
            {
                double fractorResult = 1;
                for (int i = 0;i < fractorNumber; i++)
                {
                    fractorResult = fractorResult + (fractorResult * i);                
                }

                Console.WriteLine("Number {0} Fractor is: {1} ", fractorNumber, fractorResult);
                Console.Write("\n Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Indefinable fractornumber!");
                Console.Write("\n Press any key to continue...");
                Console.ReadKey();

            }
        }
    }
}
