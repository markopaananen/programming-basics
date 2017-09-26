using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, replace character!");
            Console.WriteLine("----------------------------------------------------\n");
            Console.WriteLine("Please let some random sentense here. \n");
            string userInput = Console.ReadLine();
            Console.WriteLine("Let character to replace. \n");
            string replaceChar = Console.ReadLine();
            Console.WriteLine("Let compensatory character. \n");
            string compensatoryChar = Console.ReadLine();
            string newSting = userInput.Replace(replaceChar,compensatoryChar);
            Console.WriteLine(newSting);
            Console.ReadKey();

            int inputLenght = newSting.Length;
            for(int i =1; i< inputLenght; i++)
            {
                Console.WriteLine(newSting.Substring(i, 1));
            }
            Console.ReadKey();
        }
    }
}
