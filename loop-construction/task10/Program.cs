using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, this is standard betting!\n\n");
            int gameRow = 0;
            string result = "";
            Random gameResult = new Random();
            for(int i = 1; i < 14; i++)
            {
                //Console.WriteLine(gameResult.Next(1, 4));
                gameRow = gameResult.Next(1, 4);
                
                if (gameRow == 1)
                {
                    result = "1";
                }
                if(gameRow == 2)
                {
                    result = "X";
                }
                if (gameRow == 3)
                {
                    result = "2";
                }
                Console.WriteLine("Round {0} result {1} ", i, result);
            }

            Console.WriteLine("\n Press any key to continue...\n");
            Console.ReadKey();        }
    }
}
