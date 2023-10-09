using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Red",5);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Blue", 10,5);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Yellow", 8);
        shapes.Add(circle1);

        foreach (Shape sh in shapes)
        {
            string color = sh.GetColor();
            double area = sh.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}