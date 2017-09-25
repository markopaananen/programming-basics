using System;
public class funcexer12
{
    public static int Fib(int n1)
    {
        //if ( (n1 == 1) || (number == 2) )
        if (n1 <= 2)
            return 1;
        else
            return Fib(n1 - 1) + Fib(n1 - 2);
    }

    public static int Fibo(int nno)
    {
        int num1 = 0;
        int num2 = 1;

        for (int i = 0; i < nno; i++)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp + num2;
        }
        return num1;
    }


    public static void Main()
    {
        int num;

        Console.Write("\n\nRecursive Function : To calculate the Fibonacci number of a specific term :\n");
        Console.Write("-------------------------------------------------------------------------------\n");
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nThe Fibonacci of {0} th term  is {1} \n", num, Fib(num));

        Console.Write("\n\nFunction : To display the n number Fibonacci series :\n");
        Console.Write("------------------------------------------------------------\n");
        Console.Write("Input number of Fibonacci Series : ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The Fibonacci series of " + n + " numbers is :");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibo(i) + "  ");
           
        }
        Console.WriteLine();
        Console.ReadKey();
    }


}
