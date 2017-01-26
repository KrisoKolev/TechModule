using System;

class Program
{

    static long PowerNumber(long baseNum, long power)
    {
        long result = 1;

        for (long i = 0; i < power; i++)
        {
            result *= baseNum;
        }

        return (result);
    }

    static void Main()
    {
        long baseNum = long.Parse(Console.ReadLine());
        long power = long.Parse(Console.ReadLine());
        long result = PowerNumber(baseNum, power);

        Console.WriteLine(result);
    }
}

