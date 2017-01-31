using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //first point coordinates
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        //second point coordinates
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        //3th point coordinates
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        //4th point coordinates
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());


        double firstLine = GetLenghtOfHypotenuse(x1, y1, x2, y2);
        double secondLine = GetLenghtOfHypotenuse(x3, y3, x4, y4);

        string result = "";
        if (firstLine >= secondLine)
        {
            result = closestPointToCenter(x1, y1, x2, y2);
            Console.WriteLine(result);
        }
        else
        {
            result = closestPointToCenter(x3, y3, x4, y4);
            Console.WriteLine(result);
        }
    }

    static double GetLenghtOfHypotenuse(double x1, double y1, double x2, double y2)
    {
        double a = Math.Abs(x1 - x2);
        double b = Math.Abs(y2 - y1);

        double hypotenuse = Math.Sqrt(a * a + b * b);

        return hypotenuse;
    }

    static string closestPointToCenter(double x1, double y1, double x2, double y2)
    {
        string coordinates = "";
        if (Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(x2, 2) + Math.Pow(y2, 2))
        {
            coordinates = $"({x1}, {y1})({x2}, {y2})";
        }
        else
        {
            coordinates = $"({x2}, {y2})({x1}, {y1})";
        }

        return coordinates;
    }


}


