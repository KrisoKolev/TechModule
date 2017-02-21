using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        var dictionary = new SortedDictionary<double, int>();

        foreach (var number in numbers)
        {
            if (!dictionary.ContainsKey(number))
            {
                dictionary[number] = 0;
            }

            dictionary[number]++;
        }

        foreach (var diggit in dictionary)
        {
            Console.WriteLine($"{diggit.Key} -> {diggit.Value}");   
        }
    }
}

