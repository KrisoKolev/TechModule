using System;

public class Program
{
    public static string ReverseDigit(string number)
    {
        string numberToString = number.ToString();
        char[] symbol = numberToString.ToCharArray();

        string result = "";

        for (int i = numberToString.Length; i > 0; i--)
        {
            result += symbol[i - 1];
        }

        return result;
    }

    public static void Main()
    {
        string number = Console.ReadLine();
        string result = ReverseDigit(number);

        Console.WriteLine(result);
    }
}

