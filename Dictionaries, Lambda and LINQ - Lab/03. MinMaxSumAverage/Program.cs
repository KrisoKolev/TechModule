using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //int input = int.Parse(Console.ReadLine());

        //var nums = new List<double>();

        //double sum = 0;
        //double min = 0;
        //double max = 0;
        //double average = 0;

        //for (int i = 0; i < input; i++)
        //{
        //    double numbers = double.Parse(Console.ReadLine());

        //    nums.Add(numbers);

        //    sum += numbers;

        //    min = nums.Min();

        //    max = nums.Max();

        //    average = nums.Average();
        //}

        //Console.WriteLine($"Sum = {sum}");
        //Console.WriteLine($"Min = {min}");
        //Console.WriteLine($"Max = {max}");
        //Console.WriteLine($"Average = {average}");

        int lines = int.Parse(Console.ReadLine());

        var list = new List<int>();

        double sum = 0;
        double min = 0;
        double max = 0;
        double average = 0;

        for (int i = 0; i < lines; i++)
        {
            int numbers = int.Parse(Console.ReadLine());

            list.Add(numbers);

            sum = list.Sum();
            min = list.Min();
            max = list.Max();
            average = list.Average();
        }

        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Min = {min}");
        Console.WriteLine($"Max = {max}");
        Console.WriteLine($"Average = {average}");
    }
}

