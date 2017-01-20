using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");

        int a1 = b;
        int b1 = a;

        Console.WriteLine("After:");
        Console.WriteLine($"a = {a1}");
        Console.WriteLine($"b = {b1}");
    }
}

