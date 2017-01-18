﻿using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            int sumOfDigits = 0;
            int num = i;

            while (num > 0)
            {
                sumOfDigits = num % 10;
                num /= 10;
            }
            bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
            Console.WriteLine($"{i} -> {isSpecial}");
        }
    }
}

