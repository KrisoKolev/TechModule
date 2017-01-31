using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{

    public static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        List<int> primeList = GetPrime(firstNum, secondNum);

        Console.WriteLine(string.Join(", ", primeList));
    }

    public static List<int> GetPrime(int firstNum, int secondNum)
    {
        List<int> list = new List<int>();

        for (int i = firstNum; i <= secondNum; i++)
        {
            if (IsPrime(i))
            {
                list.Add(i);
            }
        }
        return list;
    }

    public static bool IsPrime(int number)
    {
        bool IsPrime = true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                IsPrime = false;
            }
        }

        return IsPrime;
    }
}

