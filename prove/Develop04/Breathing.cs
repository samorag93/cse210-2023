using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Threading;

public class Breathing : Activity
{
    public Breathing() : base("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n")
    {        
        
    }

    public override void DoActivity()
    {
        int elapsedTime = 0;
        while(elapsedTime < GetDuration())
        {
            Console.Write("\n\nBreath in...");
            for (int i = 0; i > 4; i--)
            {            
                Console.Write(i+"");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                               
            }
            Console.Write("\nNow breath out...");
            for (int i = 0; i > 6; i--)
            {
                Console.Write(i+"");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            elapsedTime++;
             
        }
        EndActivity();
    }
    private void ObtainTimer(int seconds)
    {
        for (int i = seconds; i >=1; i++)
        {
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft-2,Console.CursorTop);
        }
        
    }

    // private void ShowAnimationIn()
    // {
    //     Console.WriteLine("Breathe in... (  )");
    //     Thread.Sleep(500);
    //     Console.WriteLine("Breathe in... (  )");
    //     Thread.Sleep(500);
    //     Console.WriteLine("Breathe in... (  )");
    //     Thread.Sleep(500);
    //     Console.WriteLine("Breathe in... (  )");
    //     Thread.Sleep(500);
    //     Console.WriteLine("Breathe in... (  )");
    //     Thread.Sleep(500);
    //     Console.WriteLine("Breathe in... (  )");
    //     Thread.Sleep(500);
    // }
    // private void ShowAnimationOUt()
    // {
    //     Console.WriteLine("Breathe out... (  )");
    //     Thread.Sleep(500);
    //     Console.WriteLine("Breathe out... (  )");
    //     Thread.Sleep(500);
    //     Console.WriteLine("Breathe out... (  )");
    //     Thread.Sleep(500);
    //     Console.WriteLine("Breathe out... (  )");
    //     Thread.Sleep(500);
    //     Console.WriteLine("Breathe out... (  )");
    //     Thread.Sleep(500);
    //     Console.WriteLine("Breathe out... (  )");
    //     Thread.Sleep(500);
    // }
}


// using System;
// using System.Threading;

// class ActividadRespiratoria : Actividad
// {
//     public override void Realizar()
//     {
//         base.Realizar();

//         int duracion = SolicitarDuracion();

//         Console.WriteLine("Prepárate para comenzar...");
//         Thread.Sleep(2000);

//         Console.Clear();
//         Console.WriteLine("Actividad Respiratoria");
//         Console.WriteLine("Esta actividad te ayudará a relajarte al inhalar y exhalar lentamente. Despeja tu mente y concéntrate en tu respiración.");

//         RealizarAnimacionRespiracion(duracion);

//         Console.Clear();
//         foreach (string mensaje in mensajesFinales)
//         {
//             Console.WriteLine(mensaje, duracion);
//             Thread.Sleep(1000);
//         }

//         Console.WriteLine("Presiona Enter para volver al menú principal...");
//         Console.ReadLine();
//     }

//     private void RealizarAnimacionRespiracion(int duracion)
//     {
//         string[] animacion = {
//             "Inhala...",
//             "Exhala...",
//         };
//         int velocidad = duracion * 1000 / (animacion.Length * 2);

//         for (int i = 0; i < duracion; i++)
//         {
//             foreach (string frame in animacion)
//             {
//                 Console.Clear();
//                 Console.WriteLine(frame);
//                 Thread.Sleep(velocidad);
//             }
//         }
//     }
// }
