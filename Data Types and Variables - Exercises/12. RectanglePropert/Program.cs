using System;
class Program
{
    static void Main()
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());

        double perimeter = (2 * length) + (2 * width);
        double area = length * width;
        double diagonal = Math.Sqrt((length * length) + (width * width));

        Console.WriteLine(perimeter);
        Console.WriteLine(area);
        Console.WriteLine(diagonal);
    }
}

