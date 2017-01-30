using System;

public class Program
{
    public static double CalculationFaceDiagonals(double side)
    {
        double neededCalculation = 2 * (side * side);
        double result = Math.Sqrt(neededCalculation);

        return result;
    }

    public static double CalculationSpaceDiagonals(double side)
    {
        double neededCalculation = 3 * (side * side);
        double result = Math.Sqrt(neededCalculation);

        return result;
    }

    public static double CalculationVolumeOfCube(double side)
    {
        double result = side * side * side;

        return result;
    }

    public static double CalculateAreaOfCube(double side)
    {
        double result = 6 * (side * side);

        return result;
    }

    public static void Main()
    {
        double sideOfCub = double.Parse(Console.ReadLine());
        string parameterOfCub = Console.ReadLine();

        if (parameterOfCub == "face")
        {
            double result = CalculationFaceDiagonals(sideOfCub);
            Console.WriteLine(Math.Round(result, 2));
        }
        else if (parameterOfCub == "space")
        {
            double result = CalculationSpaceDiagonals(sideOfCub);
            Console.WriteLine(Math.Round(result, 2));
        }

        else if (parameterOfCub == "volume")
        {
            double result = CalculationVolumeOfCube(sideOfCub);
            Console.WriteLine(Math.Round(result, 2));
        }

        else if (parameterOfCub == "area")
        {
            double result = CalculateAreaOfCube(sideOfCub);
            Console.WriteLine(Math.Round(result, 2));
        }

        else
        {
            Console.WriteLine("Wrong perimeter!");
        }
    }
}

