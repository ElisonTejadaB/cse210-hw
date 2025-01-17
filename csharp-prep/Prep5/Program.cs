using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Elison Tejada Prep5 World!");
        DisplayWelcome();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int Squared = SquaredNumber(UserNumber);
        DisplayResult(UserName, Squared);
        



    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string Name = Console.ReadLine();
        return Name;
    }

    static int PromptUserNumber()

    {
        Console.Write("Please enter your favority number: ");
        int Number = int.Parse(Console.ReadLine());
        return Number;
    }
    static int SquaredNumber(int Number)
    {
        int square = Number *Number;
        return square;
    }

    static void DisplayResult(string Name, int square)
    {
        Console.WriteLine($"{Name}, the square of your number is {square}");
    }
}