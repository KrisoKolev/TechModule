using System;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        bool bool0 = Convert.ToBoolean(word);
        if (bool0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

