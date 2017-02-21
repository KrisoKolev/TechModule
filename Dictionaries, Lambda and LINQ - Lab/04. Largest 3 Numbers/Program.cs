using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var result = new List<double>();

        numbers.Sort();
        numbers.Reverse();

        if (numbers.Count < 4)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                result.Add(numbers[i]);
            }
        }

        else
        {
            for (int i = 0; i <= 2; i++)
            {
                result.Add(numbers[i]);
            }
        }

    Console.WriteLine(string.Join(" ", result));
    }
}
