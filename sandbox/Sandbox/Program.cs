using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal!");

        GestorDiario gestor = new GestorDiario();
        gestor.Ejecutar();
    }
}