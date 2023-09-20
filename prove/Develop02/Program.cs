using System;

class Program
{
    static void Main(string[] args)
    {
        int usernumber;
        Console.WriteLine("Welcome to the journal!");
        Console.WriteLine("Please select one option:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        usernumber = int.Parse(Console.ReadLine());
        List<string> randomQuestion = new List<string>();
        if (usernumber == 1)
        {
            randomQuestion.Add("Who was the most interesting person I interacted with today?");
            randomQuestion.Add("What was the best part of my day?");
            randomQuestion.Add("How did I see the hand of the Lord in my life today?");
            randomQuestion.Add("What was the strongest emotion I felt today?");
            randomQuestion.Add("If I had one thing I could do over today, what would it be?");

        }
        else if (usernumber == 4)
        {
            SaveToFile(usernumber);
        }
    }


    public static void SaveToFile(int usernumber)
    {
        string fileName = "journal.txt";
        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            Console.WriteLine("Hola mundo"); 
        }

    }
}