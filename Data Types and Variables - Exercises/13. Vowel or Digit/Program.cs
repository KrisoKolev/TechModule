using System;
class Program
{
    static void Main()
    {

        char input = char.Parse(Console.ReadLine());

        if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
        {
            Console.WriteLine("vowel");
        }
        else if (input >= '0' && input <= '9')
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}

