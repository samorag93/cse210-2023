using System;
using System.IO;
using System.Collections.Generic;

public class Mastery
{
    private string[] paragraphs;

    public Mastery(string filePath)
    {
        try
        {
            paragraphs = File.ReadAllLines(filePath);

            if (paragraphs.Length == 0)
            {
                Console.WriteLine("El archivo está vacío.");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error al leer el archivo: {ex.Message}");
        }
    }

    public int GetParagraphCount()
    {
        return paragraphs.Length;
    }

    public string GetParagraph(int index)
    {
        if (index >= 0 && index < paragraphs.Length)
        {
            return paragraphs[index];
        }
        return null;
    }
}
