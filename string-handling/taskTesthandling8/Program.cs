using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] creditcard)
        {
            int sum = 0, d;
            string num = "410820416189";
            int a = 0;
            for (int i = num.Length - 2; i >= 0; i--)
            {
                d = Convert.ToInt32(num.Substring(i, 1));
                if (a % 2 == 0)
                    d = d * 2;
                if (d > 9)
                    d -= 9;
                sum += d;
                a++;
            }
            if ((10 - (sum % 10) == Convert.ToInt32(num.Substring(num.Length - 1))))
            {
                Console.WriteLine("valid");
                Console.ReadKey();
            }
            Console.WriteLine("sum of digits of the number" + sum);
            Console.ReadKey();
        }
    }
}
