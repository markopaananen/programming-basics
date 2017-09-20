using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, let's multiply! \n");
            string printLine = " {0}  x  {1}  =  {2}";

            for(int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    double result = i * j;
                    Console.WriteLine(printLine, i, j, result);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
