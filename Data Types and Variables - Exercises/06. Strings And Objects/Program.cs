using System;

class Program
{
    static void Main()
    {
        string strOne = "Hello";
        string strTwo = "World";
        object joining = strOne + ' ' + strTwo;
        string joiningWord = joining.ToString();
        Console.WriteLine(joiningWord);
    }
}

