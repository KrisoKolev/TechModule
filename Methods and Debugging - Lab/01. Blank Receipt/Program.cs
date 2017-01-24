using System;

class Program
{
    static void PrintReceiptHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        for (int i = 0; i < 30; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }

    static void PrintReceiptBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }

    static void PrintReceiptFooter()
    {
        for (int i = 0; i < 30; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        Console.WriteLine(Convert.ToChar('\u00A9') + " " + "SoftUni");
    }
    
    static void PrintReceipt()
    {
        PrintReceiptHeader();
        PrintReceiptBody();
        PrintReceiptFooter();
    }

    static void Main()
    {
        PrintReceipt();
    }
}

