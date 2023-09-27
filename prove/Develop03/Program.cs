using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Do you want to upload a file?(Y/N)");
        string loadFromFile = Console.ReadLine();

        Mastery loader = null;

        if (loadFromFile.ToLower() == "y")
        {
            Console.WriteLine("Enter the file name:");
            string fileName = Console.ReadLine();

            loader = new Mastery(fileName);

            if (loader.GetParagraphCount() == 0)
            {
                return;
            }
        }
        else
        {
            Console.WriteLine("See you next time!");
            return;
        }

        int selectedParagraphIndex;

        while (true)
        {
            Console.WriteLine("Available Scriptures:");

            for (int i = 0; i < loader.GetParagraphCount(); i++)
            {
                Console.WriteLine($"{i + 1}. {loader.GetParagraph(i)}");
            }

            Console.WriteLine("\nChoose Scripture (1-" + loader.GetParagraphCount() + ") or tap 'quit' to finish");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "salir")
            {
                return;
            }

            if (int.TryParse(userInput, out selectedParagraphIndex) &&
                selectedParagraphIndex >= 1 && selectedParagraphIndex <= loader.GetParagraphCount())
            {
                Scripture paragraph = new Scripture(loader.GetParagraph(selectedParagraphIndex - 1));

                while (!paragraph.AreAllWordsHidden())
                {
                    Console.Clear();
                    Console.WriteLine(paragraph.GetTextWithHiddenWords());
                    Console.WriteLine("\nPress enter or tap 'quit' to finish.");

                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                    {
                        return;
                    }

                    paragraph.HideRandomWords(3); 
                }

                Console.WriteLine("Well Done!");
                return;
            }
            else
            {
                Console.WriteLine("Enter valid option!");
            }
        }
    }
}

