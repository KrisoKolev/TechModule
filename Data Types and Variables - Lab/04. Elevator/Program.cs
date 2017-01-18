using System;

class Program
{
    static void Main()
    {
        int waitingPeople = int.Parse(Console.ReadLine());
        int elevatorCapacity = int.Parse(Console.ReadLine());
        int courses = (int)Math.Ceiling((double)waitingPeople / elevatorCapacity);

        Console.WriteLine(courses);
    }
}

