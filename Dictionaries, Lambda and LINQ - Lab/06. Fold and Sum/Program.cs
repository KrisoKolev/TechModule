using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var k = numbers.Length / 4;

        var firstLineLeft = numbers
            .Take(k)
            .Reverse()
            .ToArray();

        var firstLineRight = numbers
            .Reverse()
            .Take(k)
            .ToArray();

        var firstLine = firstLineLeft
            .Concat(firstLineRight)
            .ToArray();

        var secondLine = numbers
            .Skip(k)
            .Take(2 * k)
            .ToArray();

        var result = firstLine
            .Zip(secondLine, (x, y) => x + y)
            .ToArray();

        Console.Write(string.Join(" ", result));
        Console.WriteLine();
    }
}

