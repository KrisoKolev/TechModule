using System;
using System.Collections.Generic;

public class Program
{
    
    public static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine(PrintPointCoordinates(x1, y1, x2, y2));
    }

    public static string PrintPointCoordinates(double x1, double y1, double x2, double y2)
    {
        double a = Math.Abs(y1);
        double b = Math.Abs(x1);
        double c = Math.Abs(a * a + b * b);
        double a2 = Math.Abs(y2);
        double b2 = Math.Abs(x2);
        double c2 = Math.Abs(a2 * a2 + b2 * b2);

        string coordinates = "";

        if (c < c2)
        {
            coordinates = $"({x1}, {y1})";
        }
        else
        {
            coordinates = $"({x2}, {y2})";
        }

        return coordinates;
    }
}

