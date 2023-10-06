using System;
using System.Diagnostics;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        int option;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Strart reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            Activity currentActivity = null;
            switch (option)
            {
                case 1:
                    currentActivity = new Breathing();
                    // Console.WriteLine();
                    break;
                case 2:
                    currentActivity = new Reflection();
                    break;
                case 3:
                    currentActivity = new Listing();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the activities app!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    Console.WriteLine("Select a choice from the menu");
                    break;
            }
            if (currentActivity != null)
            {
                currentActivity.StartActivity();
                currentActivity.DoActivity();
                // currentActivity.EndActivity();
            }
        }
        while (option != 4);
    }
}

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.Clear();
//             Console.WriteLine("=== Menú Principal ===");
//             Console.WriteLine("Seleccione una actividad:");
//             Console.WriteLine("1. Actividad Respiratoria");
//             Console.WriteLine("2. Actividad de Reflexión");
//             Console.WriteLine("3. Actividad de Listado");
//             Console.WriteLine("4. Salir");

//             char opcion = Console.ReadKey().KeyChar;
//             Console.Clear();

//             Actividad actividad = null;

//             switch (opcion)
//             {
//                 case '1':
//                     actividad = new ActividadRespiratoria();
//                     break;
//                 case '2':
//                     actividad = new ActividadReflexion();
//                     break;
//                 case '3':
//                     actividad = new ActividadListado();
//                     break;
//                 case '4':
//                     Console.WriteLine("Gracias por usar la aplicación. ¡Hasta luego!");
//                     return;
//                 default:
//                     Console.WriteLine("Opción no válida. Presione Enter para volver al menú principal...");
//                     Console.ReadLine();
//                     continue;
//             }

//             actividad.Realizar();
//         }
//     }
// }
