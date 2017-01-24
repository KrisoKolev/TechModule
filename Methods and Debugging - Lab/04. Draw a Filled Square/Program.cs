using System;

class Program
{
    static void PrintHeaderLine(int n)
    {
        Console.WriteLine(new string('-', n * 2));
    }

    static void PrintMiddleLines(int n)
    {
        Console.Write('-');

        for (int i = 1; i < n; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine('-');
    }

    static void PrintTheRestLines(int n)
    {
        PrintHeaderLine(n);

        for (int i = 0; i < n - 2; i++)
        {
            PrintMiddleLines(n);
        }

        PrintHeaderLine(n);
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintTheRestLines(n);
    }
}

