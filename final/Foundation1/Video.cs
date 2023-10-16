using System;
using System.Collections.Generic;

public class Video
{
    private string _title { get; set; }
    private string _author { get; set; }
    private int _duration { get; set; }
    public List<Comment> _comments { get; set; }

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }

    public int GetCommentsCount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        // Console.WriteLine($"Título: {_title}");
        // Console.WriteLine($"Autor: {_author}");
        // Console.WriteLine($"Duración: {_duration} segundos");
        Console.WriteLine($"---Title: {_title}, Author: {_author}, Duration: {_duration}---");
        Console.WriteLine($"Number of comments: {GetCommentsCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"  {comment._commenterName}: {comment._text}");
        }
        Console.WriteLine("\n");
    }
}
