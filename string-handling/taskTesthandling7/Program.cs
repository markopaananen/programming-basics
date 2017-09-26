using System;

namespace taskTesthandling7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int palloja;

            Console.Write("Kuinka monta jäätelöpalloa laitetaan (1-3): ");

            palloja = int.Parse(Console.ReadLine());

            decimal hinta = 0m;



            switch (palloja)

            {

                case 1:

                    hinta += 2.0m;

                    break;

                case 2:

                    hinta += 1.0m;

                    goto case 1;

                case 3:

                    hinta += 0.5m;

                    goto case 2;

                default:

                    throw new Exception("Kone ei voi tehdä pallottomia eikä yli kolmen pallon annoksia");

            }

            Console.WriteLine("Syötä koneeseen {0:0.00} euroa", hinta);
            Console.ReadKey();
        }
    }
}
