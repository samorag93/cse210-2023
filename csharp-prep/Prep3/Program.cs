using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        
        int guessNumber;
        // Console.Write("What is the magic number? ");
        // magicNumber = int.Parse(Console.ReadLine());
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1,100);
        guessNumber = 0;
        
        while(guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            if ( guessNumber== magicNumber)
            {
            Console.WriteLine("You guessed it!");
            }
            else if(guessNumber < magicNumber)
            {
            Console.WriteLine("Higher");
            }
            else
            {
            Console.WriteLine("Lower");
            }
        }        
    }
}