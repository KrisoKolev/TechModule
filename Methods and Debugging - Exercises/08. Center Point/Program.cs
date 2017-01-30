using System;
using System.Collections.Generic;

public class Program
{
    public static decimal CountDistance(decimal x, decimal y)
    {
        decimal distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        return distance;
    }

    public static void Main()
    {
        decimal x1 = decimal.Parse(Console.ReadLine());
        decimal y1 = decimal.Parse(Console.ReadLine());
        decimal x2 = decimal.Parse(Console.ReadLine());
        decimal y2 = decimal.Parse(Console.ReadLine());

        decimal countOne = CountDistance(x1, y1);
        decimal countTwo = CountDistance(x2, y2);

        var list = new List<decimal>();

        if (countOne >= countTwo)
        {
            list.Add(x2);
            list.Add(y2);
        }
        else
        {
            list.Add(x1);
            list.Add(x2);
        }

        Console.Write("(");
        Console.Write(String.Join(", ", list));
        Console.WriteLine(")");
    }
}

