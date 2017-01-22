using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int a = 0; a < n; a++)
        {
            for (int b = 0; b < n; b++)
            {
                for (int c = 0; c < n; c++)
                {
                    char lett1 = (char)('a' + a);
                    char lett2 = (char)('a' + b);
                    char lett3 = (char)('a' + c);

                    Console.WriteLine("{0}{1}{2}", lett1, lett2, lett3);
                }
            }
        }
    }
}

