using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, count specific character!");
            Console.WriteLine("----------------------------------------------------\n");
            Console.WriteLine("Please let some random sentense here. \n");
            string userInput = Console.ReadLine();
            Console.WriteLine("Let character to count. \n");
            string countedChar = Console.ReadLine();
            int result = 0;

            int inputLenght = userInput.Length;
            for (int i = 0; i < inputLenght; i++)
            {
                if (userInput.Substring(i, 1) == countedChar)
                {
                    result = result + 1;
                }
            }
            Console.WriteLine("{0} characters found.\n", result);
            Console.ReadKey();
        }
    }
}