using System;

class Program
{
    static void Main(string[] args)
    {
        Assignents assignents = new Assignents("Samuel Bennett","Multiplication");
        Console.WriteLine(assignents.GetSummary());

        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomework());

        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetList());
    }
}