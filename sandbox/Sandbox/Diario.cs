using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    private List<EntradaDiario> entradas = new List<EntradaDiario>();

    public void AgregarEntrada(EntradaDiario entrada)
    {
        entradas.Add(entrada);
    }

    public List<EntradaDiario> ObtenerTodasLasEntradas()
    {
        return entradas;
    }

    public void LimpiarEntradas()
    {
        entradas.Clear();
    }

    public void GuardarEnArchivo(string nombreArchivo)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(nombreArchivo))
            {
                foreach (var entrada in entradas)
                {
                    writer.WriteLine($"Date: {entrada.Date}");
                    writer.WriteLine($"Prompt: {entrada.Prompt}");
                    writer.WriteLine($"> {entrada.Answer}");
                    writer.WriteLine();
                }
            }
            Console.WriteLine("Journal Saved...");
        }
        catch (IOException e)
        {
            Console.WriteLine("Error saving file: " + e.Message);
        }
    }

    public void CargarDesdeArchivo(string nombreArchivo)
    {
        if (File.Exists(nombreArchivo))
        {
            entradas.Clear();
            using (StreamReader reader = new StreamReader(nombreArchivo))
            {
                EntradaDiario entrada = null;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line.StartsWith("Date: "))
                    {
                        entrada = new EntradaDiario
                        {
                            Date = DateTime.Parse(line.Substring(7))
                        };
                    }
                    else if (line.StartsWith("Prompt: "))
                    {
                        entrada.Prompt = line.Substring(12);
                    }
                    else if (line.StartsWith("Answer: "))
                    {
                        entrada.Answer = line.Substring(11);
                        entradas.Add(entrada);
                    }
                }
            }
            Console.WriteLine("Diario cargado desde el archivo.");
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }
    }
}
