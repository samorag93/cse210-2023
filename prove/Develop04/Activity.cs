using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private int _activityAccount;
    private List<string> _question;
    private List<string> _usedQuestions;
    private List<string> _thinkQuestion;
    private int duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _question = new List<string>();
        _usedQuestions = new List<string>();
        _thinkQuestion = new List<string>();
        _activityAccount = 0;
    }

    protected Activity(int duration)
    {
        this.duration = duration;
    }

    public abstract void DoActivity();

    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public List<string> GetQuestions()
    {
        return _question;
    }
    public List<string> GetUsedQuestions()
    {
        return _usedQuestions;
    }
    public List<string> GetThinkQuestion()
    {
        return _thinkQuestion;
    }
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name} Activity\n");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for this session: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowAnimation();
        Thread.Sleep(1000);
    }

    public void EndActivity()
    {
        // _activityAccount++;
        // Console.Clear();
        Console.WriteLine("\nWell done!!");
        ShowAnimation();
        Console.WriteLine($"\nYou have completed {_name} activity in {_duration} seconds");
        ShowAnimation();
        Thread.Sleep(3000);
    }

    public void ShowAnimation()
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        foreach (string ani in animation)
        {
            Console.Write(ani);
            Thread.Sleep(500);
            Console.Write("\b \b");           
        }
    }
}


// using System;
// using System.Threading;

// class Actividad
// {
//     protected string[] mensajesIniciales = {
//         "¡Bienvenido a la actividad!",
//         "Esta actividad te ayudará a...",
//         "Por favor, ingresa la duración en segundos:"
//     };

//     protected string[] mensajesFinales = {
//         "¡Bien hecho! Has completado la actividad.",
//         "Tiempo transcurrido: {0} segundos"
//     };

//     public virtual void Realizar()
//     {
//         Console.Clear();
//         foreach (string mensaje in mensajesIniciales)
//         {
//             Console.WriteLine(mensaje);
//             Thread.Sleep(1000);
//         }
//     }

//     protected int SolicitarDuracion()
//     {
//         Console.Write("Duración (en segundos): ");
//         int duracion;
//         while (!int.TryParse(Console.ReadLine(), out duracion) || duracion <= 0)
//         {
//             Console.WriteLine("Ingrese una duración válida (mayor que 0): ");
//         }
//         return duracion;
//     }

//     protected void MostrarAnimacion(string[] animacion, int velocidad)
//     {
//         foreach (string frame in animacion)
//         {
//             Console.Clear();
//             Console.WriteLine(frame);
//             Thread.Sleep(velocidad);
//         }
//     }
// }
