using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!, ten first ineger and squareroots");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Integer : {0}, Squareroot : {1}", i, Math.Sqrt(i));
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
