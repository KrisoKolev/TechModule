using System;

class Program
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        Console.WriteLine("{0:f12}", pi * r * r);
    }
}

