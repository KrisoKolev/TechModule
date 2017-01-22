using System;
class Program
{
    static void Main()
    {
        Console.Write("Length: ");
        double lenght = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());

        double sum = ((lenght * width) * height) / 3;

        Console.WriteLine("Pyramid Volume: {0:f2}", sum);
    }
}

