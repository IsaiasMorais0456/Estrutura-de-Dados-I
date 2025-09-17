using System;

    /* class Program

    static void Main()
    {
        Console.WriteLine("Fibonacci Recursivo");
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine($"Fibonacci de {i} é: {F(i)}");
        }
    }

    static int F(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return F(n - 1) + F(n - 2);
    }
} */




namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine($"The factorial of {x} is {factorial(x)}");
            Console.ReadKey();
        }
        static int factorial(int number)
        {
            if (number == 1)
            {
                return (1); /* exiting condition */
            }
            else
            {
                return (number * factorial(number - 1));
            }
        }
    }
}