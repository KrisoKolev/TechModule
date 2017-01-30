using System;

class Program
{
    public static string EnglishNameOfLastDigit(long n)
    {
        int number = Math.Abs((int)(n % 10));
        string name = "";

        if (number == 0)
        {
            name = "zero";
        }
        else if (number == 1)
        {
            name = "one";
        }
        else if (number == 2)
        {
            name = "two";
        }
        else if (number == 3)
        {
            name = "three";
        }
        else if (number == 4)
        {
            name = "four";
        }
        else if (number == 5)
        {
            name = "five";
        }
        else if (number == 6)
        {
            name = "six";
        }
        else if (number == 7)
        {
            name = "seven";
        }
        else if (number == 8)
        {
            name = "eight";
        }
        else if (number == 9)
        {
            name = "nine";
        }

        return name;

    }

    public static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        string name = EnglishNameOfLastDigit(number);

        Console.WriteLine(name);
    }
}

