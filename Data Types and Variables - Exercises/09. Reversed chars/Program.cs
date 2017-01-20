using System;
class Program
{
    static void Main()
    {
        string firstLett = Console.ReadLine();
        string secondLett = Console.ReadLine();
        string lastLett = Console.ReadLine();

        object joining = lastLett +  secondLett + firstLett;

        Console.WriteLine(joining);
    }
}

