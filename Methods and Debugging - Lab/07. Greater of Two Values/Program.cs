using System;

class Program
{
    public static int GetMax(int firstNum, int secondNum)
    {
        if (firstNum > secondNum)
        {
            return firstNum;
        }
        else
        {
            return secondNum;
        }
    }

    public static char GetMax(char firstChar, char secondChar)
    {
        if (firstChar < secondChar)
        {
            return secondChar;
        }
        else
        {
            return firstChar;
        }
    }

    public static string GetMax(string firstString, string secondString)
    {
        if (firstString.CompareTo(secondString) > 0)
        {
            return firstString;
        }
        else
        {
            return secondString;
        }
    }

    public static void Main()
    {
        string type = Console.ReadLine();

        if (type == "int")
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(firstNum, secondNum));
        }
        else if (type == "char")
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(firstChar, secondChar));
        }
        else
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            Console.WriteLine(GetMax(firstString, secondString));
        }
    }
}

