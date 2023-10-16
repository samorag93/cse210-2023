using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        // Crear videos y comentarios
        Video _video1 = new Video("Tutorial de C#", "CSharpMaster123", 120);
        _video1._comments.Add(new Comment("Usuario1", "Gran tutorial, ¡gracias!"));
        _video1._comments.Add(new Comment("Usuario2", "No entendí la parte sobre bucles."));
        _video1._comments.Add(new Comment("Usuario3", "Muy útil, ¡gracias!"));

        Video _video2 = new Video("Receta de pastel de vainilla", "BakeQueen2000", 180);
        _video2._comments.Add(new Comment("Usuario4", "Se ve delicioso, definitivamente lo intentaré."));
        _video2._comments.Add(new Comment("Usuario5", "¿Se puede usar harina de trigo integral en lugar de harina normal?"));
        _video2._comments.Add(new Comment("Usuario6", "¡Gracias por compartir!"));

        _videos.Add(_video1);
        _videos.Add(_video2);
        Console.Clear();
        // Mostrar información de los videos y comentarios
        foreach (var _video in _videos)
        {
            _video.Display();
        }
    }
}
