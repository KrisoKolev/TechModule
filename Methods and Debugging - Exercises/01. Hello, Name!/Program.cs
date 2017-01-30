using System;

class Program
{

    public static string GreaterByName(string name)
    {
        return $"Hello, {name}!";
    }

    public static void Main()
    {
        string name = Console.ReadLine();
        string joining = GreaterByName(name);

        Console.WriteLine(joining);
    }
}
