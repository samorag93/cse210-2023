using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        Console.Write("enter your grade: ");
        grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
            Console.WriteLine("Your grade is: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is: C");
        }
        else if(grade >= 60)
        {
            Console.WriteLine("Your grade is: D");
        }
        else 
        {
            Console.WriteLine("Your grade is: F");
        }

        if (grade >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else 
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}