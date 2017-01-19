using System;

class Program
{
    static void Main()
    {
        decimal expression = 0xFE;
        decimal expressionTwo = 0x37;
        decimal expressionThree = 0x10;

        Console.WriteLine(Convert.ToInt32(expression));
        Console.WriteLine(Convert.ToInt32(expressionTwo));
        Console.WriteLine(Convert.ToInt32(expressionThree));
    }
}

