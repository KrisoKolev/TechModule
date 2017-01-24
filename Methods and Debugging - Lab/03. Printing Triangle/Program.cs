using System;

class Program
{
    static void PrintHeaderOfRectangle(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            PrintHeaderOfRectangle(1, i);
        }

        PrintHeaderOfRectangle(1, n);

        for (int i = n - 1; i >= 0; i--)
        {
            PrintHeaderOfRectangle(1, i);
        }
    }
}

