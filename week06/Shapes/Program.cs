using System;

class Program
{
    static void Main(string[] args)
    {
        Square sqr = new Square("Blue - Square", 15);
        Console.WriteLine(sqr.GetColor());
        Console.WriteLine(sqr.GetArea());

        Rectangle rec = new Rectangle("Green - Rectangle", 10, 10);
        Console.WriteLine(rec.GetColor());
        Console.WriteLine(rec.GetArea());

        Circle cir = new Circle("Purple - Circle", 5);
        Console.WriteLine(cir.GetColor());
        Console.WriteLine(cir.GetArea());        
        
        Console.WriteLine();

        List<Shape>shapes = new List<Shape>();
        shapes.Add(sqr);
        shapes.Add(rec);
        shapes.Add(cir);

        foreach (Shape shape in shapes){
        Console.WriteLine(shape.GetColor());
        Console.WriteLine(shape.GetArea());        
        }
    }
}