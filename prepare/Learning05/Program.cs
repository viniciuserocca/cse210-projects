using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s = new Square("Red", 3);
        shapes.Add(s);

        Rectangle r = new Rectangle("Blue", 4, 5);
        shapes.Add(r);

        Circle c = new Circle("Green", 6);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}