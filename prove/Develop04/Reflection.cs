using System;
using System.Threading;

public class Reflection : Activity
{
    public readonly List<string> RandomMessages = new List<string>
    {
        "Think about a time when you stood up for someone else.",
        "Think about a time when you did something really difficult.",
        "Think about a time when you helped someone in need.",
        "Think about a time when you did something truly selfless."
    };
    public readonly List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
    	"Have you ever done anything like this before?",
        "How did you start?",
        "How did you feel when it was complete?",
        "What made this era different from others in which it was not as successful?",
        "What do you like most about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection() : base("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n")
    {        
        
    }

    

    public override void DoActivity()
    {
        Console.Clear();
        Random random = new Random();

        string randomMessages = RandomMessages[random.Next(RandomMessages.Count)];
        Console.WriteLine(randomMessages);
        Thread.Sleep(2000);

        int elapsedTime = 0;
        while (elapsedTime < GetDuration())
        {
            string randomQuestion = Questions[random.Next(Questions.Count)];
            Console.WriteLine(randomQuestion);
            // for (int i = 0; i < 5; i++)
            // {
            //     Console.Write("\r|");
            //     Thread.Sleep(200);
            //     Console.Write("\r/");
            //     Thread.Sleep(200);
            //     Console.Write("\r-");
            //     Thread.Sleep(200);
            //     Console.Write("\r\\");
            //     Thread.Sleep(200);
            // }
            ShowAnimation();
            Console.WriteLine();
            Thread.Sleep(2000);
            elapsedTime += 2;
        }
        EndActivity();
    }
}

// using System;
// using System.Threading;

// // class ActividadReflexion : Actividad
// // {
// //     private string[] mensajesReflexion = {
// //         "Piensa en un momento en el que defendiste a otra persona.",
// //         "Piensa en un momento en el que hiciste algo realmente difícil.",
// //         "Piensa en un momento en el que ayudaste a alguien necesitado.",
// //         "Piensa en un momento en el que hiciste algo verdaderamente desinteresado."
// //     };

    // private string[] preguntas = {
    //     "¿Por qué fue significativa para usted esta experiencia?",
    //     "¿Alguna vez habías hecho algo como esto antes?",
    //     "¿Cómo empezaste?",
    //     "¿Cómo te sentiste cuando estuvo completo?",
    //     "¿Qué hizo que esta época fuera diferente a otras en las que no tuvo tanto éxito?",
    //     "¿Qué es lo que más te gusta de esta experiencia?",
    //     "¿Qué podrías aprender de esta experiencia que se aplique a otras situaciones?",
    //     "¿Qué aprendiste sobre ti mismo a través de esta experiencia?",
    //     "¿Cómo puedes tener presente esta experiencia en el futuro?"
    // };

// //     public override void Realizar()
// //     {
// //         base.Realizar();

// //         int duracion = SolicitarDuracion();

// //         Console.WriteLine("Prepárate para comenzar...");
// //         Thread.Sleep(2000);

// //         Console.Clear();
// //         Console.WriteLine("Actividad de Reflexión");
// //         Console.WriteLine("Esta actividad te ayudará a reflexionar sobre momentos de tu vida en los que has demostrado fortaleza y resiliencia. Esto te ayudará a reconocer el poder que tienes y cómo puedes usarlo en otros aspectos de tu vida.");

// //         RealizarReflexion(duracion);

// //         Console.Clear();
// //         foreach (string mensaje in mensajesFinales)
// //         {
// //             Console.WriteLine(mensaje, duracion);
// //             Thread.Sleep(1000);
// //         }

// //         Console.WriteLine("Presiona Enter para volver al menú principal...");
// //         Console.ReadLine();
// //     }

// //     private void RealizarReflexion(int duracion)
// //     {
// //         int velocidad = 1000;

// //         for (int i = 0; i < duracion; i++)
// //         {
// //             string mensajeReflexion = mensajesReflexion[i % mensajesReflexion.Length];
// //             Console.Clear();
// //             Console.WriteLine(mensajeReflexion);

// //             Thread.Sleep(velocidad * 3);

// //             Shuffle(preguntas);
// //             foreach (string pregunta in preguntas)
// //             {
// //                 Console.Clear();
// //                 Console.WriteLine(mensajeReflexion);
// //                 Console.WriteLine(pregunta);
// //                 Thread.Sleep(velocidad);
// //             }
// //         }
// //     }

//     private void Shuffle(string[] array)
//     {
//         Random rng = new Random();
//         int n = array.Length;
//         while (n > 1)
//         {
//             n--;
//             int k = rng.Next(n + 1);
//             string value = array[k];
//             array[k] = array[n];
//             array[n] = value;
//         }
//     }
// }
