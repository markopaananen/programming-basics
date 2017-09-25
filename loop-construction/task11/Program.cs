using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, throw dice thusand times!\n\n");
            Console.WriteLine("How many throws? \n");

            int result = 0;
            int times = 1;
            
            Random dice = new Random();

            for (int i = 1; i <= 1000; i++)
            {
                result = dice.Next(1, 7);
                if (result == 6)
                {
                    times = times + 1;
                }
                Console.WriteLine("Throw number {0}: Dise {1} ",   i, result);
            }
            Console.WriteLine("\n\n Number of six throws {0} ", times);
            Console.WriteLine("\n Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
