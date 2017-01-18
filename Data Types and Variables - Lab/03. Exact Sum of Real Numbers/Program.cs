using System;

class Program
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal sum = 0;
        for (int i = 1; i <= n; i++)
        {
            decimal numbers = decimal.Parse(Console.ReadLine());
            sum = sum + numbers;
        }
        Console.WriteLine(sum);
    }
}

