using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Lapis Lazuli", 7.3));
        shapes.Add(new Rectangle("Inverted Beige", 5.2, 3));
        shapes.Add(new Circle("Verde Oscuro", 6));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.Color} | Area: {shape.GetArea():F2}");
        }

    }
}