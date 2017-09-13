using System;

namespace task4 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n");
            Console.Write("Sort three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            string x, y, z;
            int a, b, c;

            Console.Write("Input the 1st number :");
            x = Console.ReadLine();
            a = int.Parse(x);


            Console.Write("Input the 2nd number :");
            y = Console.ReadLine();
            b = int.Parse(y);

            Console.Write("Input the 3rd  number :");
            z = Console.ReadLine();
            c = int.Parse(z);

            Console.ReadKey();

            if ((a > b) && (a > c))
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else if ((b > a) && (b > c))
            {
                if (a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
            }
            else if ((c > a) && (c > b))
            {
                if (a > b)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);

                }
            }
            Console.Write("\n\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");
            Console.Write("\n\n");

        }


    }
}
