using System;

class Program
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        long idNumber = long.Parse(Console.ReadLine());
        int employeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID: {0}", idNumber);
        Console.WriteLine($"Unique Employee number: {employeeNumber}");
    }
}

