using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n");
            Console.Write("Ticket pricing:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            // ask user information
            string age, price, student, mtk, soldier;
            int ag, pr, st, mt, so;

            
            Console.WriteLine("How old you are: ");
            age = Console.ReadLine();
            ag = int.Parse(age);
            Console.WriteLine("Are you student 1=yes, 0=no: ");
            student = Console.ReadLine();
            st = int.Parse(student);
            Console.WriteLine("Are you member of MTK 1=yes, 0=no: ");
            mtk = Console.ReadLine();
            mt = int.Parse(mtk);
            Console.WriteLine("Are you soldier 1=yes, 0=no: ");
            soldier = Console.ReadLine();
            so = int.Parse(soldier);

            // set ticketprice
            pr = 16;


            // Count ticketprice


            if (st == 0 && mt == 0 && so == 0)
            {
                if (ag < 7)
                {
                    Console.Write("Yuo have free ticket!");
                    Console.ReadKey();
                }
                else if (ag > 15 && ag < 65)
                {
                    Console.Write("Yuo have normal  ticketprice! 16 Euros ");
                    Console.ReadKey();
                }
            }
            if ((ag > 6 && ag < 15) || (ag > 65) || (so == 1))
            {
                Console.Write("Yuo have 50% discount ticketprice! 8 Euros ");
                Console.ReadKey();
            }
            if ((st == 1) && (mt == 1))
            {
                Console.Write("Yuo have 60% discount ticketprice! 6,4 Euros ");
                Console.ReadKey();
            }




            //// free
            //if ((ag < 7) || (so == 0) || (mt == 0) || (st == 0));
            //{
            //    Console.Write("Yuo have free ticket!");
            //    Console.ReadKey();
            //}

            //// TicketPrice - 60%
            //if ((mt == 1) && (st == 1))
            //{
            //    Console.Write("Yuo have 60% discount ticketprice! 7,2 Euros ");
            //    Console.ReadKey();
            //}

            //// TicketPrice - 50%
            //if ((ag > 6) && (ag < 17) || (ag > 64) || (so == 1))
            //{
            //    Console.Write("Yuo have 50% discount ticketprice! 8 Euros ");
            //    Console.ReadKey();
            //}

            //// TicketPrice - 45%
            //if (so == 1)            {
            //    Console.Write("Yuo have 45% discount ticketprice! 10,4 Euros ");
            //    Console.ReadKey();
            //}

            //// Normal TicketPrice 
            //if ((ag > 16) && (ag <75) && (so == 0) && (mt == 0) && (st == 0))
            //{
            //    Console.Write("Yuo have normal  ticketprice! 16 Euros ");
            //    Console.ReadKey();
            //}


        }
    }
}
