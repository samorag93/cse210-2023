using System;
using System.Collections.Generic;
using System.Threading;

public class Listing : Activity
{
    private readonly List<string> Questions = new List<string>
    {
        "When did you feel the Holy Spirit this month?",
        "When did you feel most inspired this month?",
        "When did you experience gratitude this month?",
        "When did you feel most connected to others this month?",
    };
    private List<string> Responses =  new List<string>();
    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n")
    {
        
    }

    public override void DoActivity()
    {
        Random random = new Random();
        string randomQuestion = Questions[random.Next(Questions.Count)];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{randomQuestion}---");
        Console.WriteLine("You may begin in:");
        int elapsedTime = 0;
        while (elapsedTime < GetDuration())
        {
            Console.Write(">");
            string entry = Console.ReadLine();
            Responses.Add(entry);
            elapsedTime++;

            if(elapsedTime < GetDuration())
            {

            }
        }
        Console.WriteLine($"Total de elementos enumerados: {Responses.Count}");
        Thread.Sleep(3000);
        EndActivity();
    }
}

// using System;
// using System.Threading;

// class ActividadListado : Actividad
// {
//     private string[] mensajesListado = {
//         "¿Quiénes son las personas que aprecias?",
//         "¿Cuáles son sus puntos fuertes personales?",
//         "¿Quiénes son las personas a las que has ayudado esta semana?",
//         "¿Cuándo has sentido el Espíritu Santo este mes?",
//         "¿Quiénes son algunos de tus héroes personales?"
//     };

//     public override void Realizar()
//     {
//         base.Realizar();

//         int duracion = SolicitarDuracion();

//         Console.WriteLine("Prepárate para comenzar...");
//         Thread.Sleep(2000);

//         Console.Clear();
//         Console.WriteLine("Actividad de Listado");
//         Console.WriteLine("Esta actividad te ayudará a reflexionar sobre las cosas buenas de tu vida al hacerte enumerar tantas cosas como puedas en un área determinada.");

//         RealizarListado(duracion);

//         Console.Clear();
//         foreach (string mensaje in mensajesFinales)
//         {
//             Console.WriteLine(mensaje, duracion);
//             Thread.Sleep(1000);
//         }

//         Console.WriteLine("Presiona Enter para volver al menú principal...");
//         Console.ReadLine();
//     }

//     private void RealizarListado(int duracion)
//     {
//         int velocidad = 1000;
//         Random random = new Random();

//         for (int i = 0; i < duracion; i++)
//         {
//             string mensajeListado = mensajesListado[random.Next(mensajesListado.Length)];
//             Console.Clear();
//             Console.WriteLine(mensajeListado);
//             Thread.Sleep(velocidad * 3);

//             Console.WriteLine("Comienza a enumerar:");

//             int contador = 1;
//             while (true)
//             {
//                 Console.Write($"{contador}. ");
//                 string elemento = Console.ReadLine();
//                 if (string.IsNullOrEmpty(elemento))
//                 {
//                     break;
//                 }
//                 contador++;
//             }
//         }
//     }
// }
