using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!, number of string character");
            Console.WriteLine("----------------------------------------------------\n");
            Console.WriteLine("Please let some random sentense here. \n");
            string userInput = Console.ReadLine();
            int inputLength = userInput.Length;
            Console.WriteLine("\n String lengght is {0} character. ", inputLength);
            Console.WriteLine("\n Press any key to continue", inputLength);
            Console.ReadKey();
        }
    }
}

