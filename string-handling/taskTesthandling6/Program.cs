using System;

namespace taskTesthandling6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, string teshandling!");
            Console.WriteLine("----------------------------------------------------\n");
            Console.WriteLine("Please let some random sentense here. \n");
            string userInput = Console.ReadLine();
            int lenInput = userInput.Length;
            string reverseInput = "";
            for (int i = lenInput; i > 0; i--)
            {
                reverseInput = reverseInput + userInput.Substring(i-1, 1);
            }
            Console.WriteLine("{0} is reverse string.\n", reverseInput);
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
            Console.WriteLine("----------------------------------------------------\n");
            if (userInput == reverseInput)
            {
                Console.WriteLine("Lucky you, your sentance is palindrome!\n");
            }
            else
            {
                Console.WriteLine("Damn you, your sentance is not palindrome!\n");
            }
            Console.ReadKey();
        }
    }
}