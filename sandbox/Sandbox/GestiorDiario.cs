using System;
using System.Collections.Generic;

public class GestorDiario
{
    private Diario diario = new Diario();
    private Random random = new Random();

    public void NuevaEntrada()
    {
        string[] prompts = {
            "What are you thinking?",
            "What do you enjoy doing the most?",
            "What blessings have changed your life?",
            "What made you happy today?",
            "What can you do today and not leave it for tomorrow?"
        };

        int indexRandom = random.Next(prompts.Length);
        string promptsRandom = prompts[indexRandom];

        Console.WriteLine($"{promptsRandom}");
        Console.Write(">");
        string respuesta = Console.ReadLine();

        EntradaDiario newEntry = new EntradaDiario
        {
            Prompt = promptsRandom,
            Answer = respuesta,
            Date = DateTime.Now
        };

        diario.AgregarEntrada(newEntry);
        Console.WriteLine("Entry Added in the Journal...");
    }

    public void MostrarDiario()
    {
        List<EntradaDiario> entradas = diario.ObtenerTodasLasEntradas();

        if (entradas.Count == 0)
        {
            Console.WriteLine("The Journal is empty");
        }
        else
        {
            Console.WriteLine("Journal Entries:");
            foreach (var entrada in entradas)
            {
                Console.WriteLine($"Date: {entrada.Date} - Prompt: {entrada.Prompt}");
                Console.WriteLine($" {entrada.Answer}");
                Console.WriteLine();
            }
        }
    }

    public void Ejecutar()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    NuevaEntrada();
                    break;
                case "2":
                    MostrarDiario();
                    break;
                case "3":
                    Console.Write("What is the file name: ");
                    string nombreArchivo = Console.ReadLine();
                    diario.GuardarEnArchivo(nombreArchivo);
                    break;
                case "4":
                    Console.Write("What is the file name: ");
                    nombreArchivo = Console.ReadLine();
                    diario.CargarDesdeArchivo(nombreArchivo);
                    break;
                case "5":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
