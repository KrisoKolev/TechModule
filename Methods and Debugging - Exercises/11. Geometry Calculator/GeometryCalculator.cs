using System;

public class GeometryCalculator
{
    public static double AreaOfTriangle()
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double triangleArea = (side * height) / 2;

        return triangleArea;
    }

    public static double AreaOfSquare()
    {
        double side = double.Parse(Console.ReadLine());
        double squareArea = side * side;

        return squareArea;
    }

    public static double AreaOfRectangle()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double rectangleArea = width * height;

        return rectangleArea;
    }

    public static double AreaOfCircle()
    {
        double radius = double.Parse(Console.ReadLine());

        double circleArea = Math.PI * (radius * radius);

        return circleArea;
    }

    public static void Main()
    {
        string figure = Console.ReadLine();

        if (figure == "triangle")
        {
            double triangleArea = AreaOfTriangle();

            Console.WriteLine("{0:F2}", triangleArea);
        }

        else if (figure == "square")
        {
            double squareArea = AreaOfSquare();

            Console.WriteLine("{0:f2}", squareArea);
        }

        else if (figure == "rectangle")
        {
            double rectangleArea = AreaOfRectangle();

            Console.WriteLine("{0:f2}", rectangleArea);
        }

        else if (figure == "circle")
        {
            double circleArea = AreaOfCircle();

            Console.WriteLine("{0:f2}", circleArea);
        }
        else
        {
            Console.WriteLine("Wrong geometry figure!");
        }
    }
}

