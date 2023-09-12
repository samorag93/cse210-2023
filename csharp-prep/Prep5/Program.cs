using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = UserName();
        int number = UserNumber();
        int square = SquareNumber(number);

        DisplayResults(name, square);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int UserNumber()
    {
       Console.Write("Please enter your favorite name: ");
       int favNumber = int.Parse(Console.ReadLine());
       return favNumber;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, your square name is {square}");
    }
}