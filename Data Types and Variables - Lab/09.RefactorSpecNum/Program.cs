using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int letter = 0;
        bool spcialNum = false;

        for (int i = 1; i <= n; i++)
        {
            letter = i;
            while (i > 0)
            {
                sum += i % 10;
                i = i / 10;
            }
            bool specialNum = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{letter} -> {specialNum}");
            sum = 0;
            i = letter;
        }
    }
}

