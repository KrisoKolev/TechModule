using System;

public class Program
{
    public static bool CheckForPrime(long number)
    {
        bool isPrime = true;

        if (number < 2)
        {
            isPrime = false;
        }

        else
        {
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        return isPrime;
    }

    public static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        bool isPrime = CheckForPrime(number);

        if (isPrime)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

