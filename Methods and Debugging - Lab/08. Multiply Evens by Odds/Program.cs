using System;

class Program
{
    public static int GetMultipleOfEvensAndOdds(int number)
    {
        return Math.Abs(GetSumOfEvenDigits(number) * GetSumOfOddDigits(number));
    }

    public static int GetSumOfOddDigits(int number)
    {
        return GetSumOfDigits(number, 0);
    }

    public static int GetSumOfEvenDigits(int number)
    {
        return GetSumOfDigits(number, 1);
    }

    public static int GetSumOfDigits(int number, int remeinder)
    {
        int result = 0;

        foreach (char symbol in number.ToString())
        {
            int digit = symbol - '0';
            if (digit % 2 == remeinder)
            {
                result += digit;
            }
        }

        return result;
    }

    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMultipleOfEvensAndOdds(input));
    }
}
