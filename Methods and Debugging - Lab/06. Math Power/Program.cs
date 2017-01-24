using System;
class Program
{
    static double PrintRiceToPower(double number, int power)
    {
        return Math.Pow(number, power);
    }

    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        double result = PrintRiceToPower(number, power);

        Console.WriteLine(result);
    }
}

