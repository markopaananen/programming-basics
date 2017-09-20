using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, twenty random numbers in four rows! \n");
            string prtLine = "";
            string prtBegin = "";
            Random rndNumb = new Random();

            for (int i = 1; i <= 4; i++)
            {
                prtBegin = "Rivi {0} ";
                int result;
                string prtSeparate = ", ";
                for (int j = 1; j <= 5; j++)
                {
                    result = rndNumb.Next(1, 51);
                    if (j != 5) //(i * j != 20 )
                    {
                        prtLine = result + prtSeparate + prtLine;                        
                    }
                    else
                    {
                        prtLine = prtLine + result;
                    }

                    
                }
                Console.WriteLine(prtBegin,i + " "+ prtLine);
                prtLine = "";
            }
            Console.WriteLine("\n Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
