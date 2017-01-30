using System;

class Program
{
    public static int Fibonacci(int number)
    {
        int a = 0;
        int b = 1;

        for (int i = -1; i < number; i++)
        {
            int sum = a;
            a = b;
            b = sum + a;
        }
        return a;
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(Fibonacci(number));
    }
}

