using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        var startData = DateTime.ParseExact(
            Console.ReadLine(), 
            "d.M.yyyy", 
            CultureInfo.InvariantCulture);

        var endData = DateTime.ParseExact(
            Console.ReadLine(), 
            "d.M.yyyy", 
            CultureInfo.InvariantCulture);

        var holidaysCount = 0;
       
        for (var date = startData; date <= endData; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || 
                date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
        }
        Console.WriteLine(holidaysCount);
    }
}

