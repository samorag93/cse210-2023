using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> words;
    private Random random = new Random();

    public Scripture(string text)
    {
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        for (int i = 0; i <= count; i++)
        {
            var visibleWords = words.Where(word => !word.IsHidden).ToList();
            if (visibleWords.Count == 0)
            {
                break; 
            }

            int randomIndex = random.Next(0, visibleWords.Count);
            visibleWords[randomIndex].Hide();
        }
    }

    public bool AreAllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }

    public string GetTextWithHiddenWords()
    {
        return string.Join(" ", words.Select(word => word.IsHidden ? "______" : word.Text));
    }
}
