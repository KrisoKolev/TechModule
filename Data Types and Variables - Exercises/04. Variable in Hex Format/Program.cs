using System;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();

        decimal convert = Convert.ToInt32(number, 16);

        Console.WriteLine(convert);
    }
}

