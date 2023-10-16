using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        // Crear videos y comentarios
        Video _video1 = new Video("Tutorial de C#", "CSharpMaster123", 120);
        _video1._comments.Add(new Comment("Usuario1", "Great tutorial, thanks!"));
        _video1._comments.Add(new Comment("Usuario2", "I don't understand the loops"));
        _video1._comments.Add(new Comment("Usuario3", "Very helpful, thanks!"));

        Video _video2 = new Video("Vanilla Cake Recipe", "BakeQueen2000", 180);
        _video2._comments.Add(new Comment("Usuario4", "It looks delicius, definitely I'll Try it"));
        _video2._comments.Add(new Comment("Usuario5", "Can whole wheat flour be used instead of regular flour?"));
        _video2._comments.Add(new Comment("Usuario6", "Thanks for sharing"));

        _videos.Add(_video1);
        _videos.Add(_video2);
        Console.Clear();
        // Display videos and comments
        foreach (var _video in _videos)
        {
            _video.Display();
        }
    }
}
