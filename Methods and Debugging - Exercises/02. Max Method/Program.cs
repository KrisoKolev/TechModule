using System;

class Program
{
    public static int GetMax(int firstNum, int secondNum, int lastNum)
    {
        if (firstNum > secondNum && firstNum > lastNum)
        {
            return firstNum;
        }
        else if (secondNum > firstNum && secondNum > lastNum)
        {
            return secondNum;
        }
        else
        {
            return lastNum;
        }
    }

    public static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int lastNum = int.Parse(Console.ReadLine());
        int output = GetMax(firstNum, secondNum, lastNum);

        Console.WriteLine(output);
    }
}

