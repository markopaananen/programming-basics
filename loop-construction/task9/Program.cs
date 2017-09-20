using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, throw crown and clown twenty times!\n\n");
            Console.WriteLine("How many throws? \n");
            string userInput = Console.ReadLine();
            int throws = int.Parse(userInput);
            int result = 0;
            int crown = 0;
            int clown = 0;

            Random coin = new Random();

            for (int i = 1; i <= throws; i++)
            {
                result = coin.Next(0, 2);
                if (result == 0)
                {
                    crown = crown + 1;
                }
                else
                {
                    clown = clown + 1;
                }
            }
            Console.WriteLine("\n\n Throws {0}: Crowns {1} and Clowns {2} ", throws, crown,clown);
            Console.WriteLine("\n Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
