using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Console.ReadLine().ToLower().Split(new[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '\'', '\"', '/', '\\', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Where(w => w.Length < 5).OrderBy(w => w).Distinct().ToList()));

        
    }
}

