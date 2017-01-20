using System;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string numHex = num.ToString("X");
        string binary = Convert.ToString(num, 2);

        Console.WriteLine(numHex);
        Console.WriteLine(binary);
    }
}

