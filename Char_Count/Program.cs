using System;
using Implementations;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("This Exe is for counting characters in a string.");

        Console.WriteLine("\n------------------------------------------------");

        Console.WriteLine("\nPlease Enter which method you want to use for counting characters in a string.");

        Console.WriteLine("\n1. Using Data Dictionary");

        int option = Convert.ToInt32(Console.ReadLine());
        string result = string.Empty;

        switch (option)
        {
            case 1:
               result = Data_Dictionary.CountCharacters("Hello World");
                break;
        }
        Console.WriteLine($"\nResult: {result}");
    }
}