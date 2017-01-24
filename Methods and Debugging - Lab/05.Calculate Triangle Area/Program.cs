using System;

class Program
{
    static double TriangleArea(double alkali, double height)
    {
        return (alkali * height) / 2;
    }

    static void Main()
    {
        double baseOfTriangle = double.Parse(Console.ReadLine());
        double heightOfTriangle = double.Parse(Console.ReadLine());

        double result = TriangleArea(baseOfTriangle, heightOfTriangle);

        Console.WriteLine(result);
    }
}

