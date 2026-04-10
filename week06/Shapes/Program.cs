using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        

        Square s = new Square("blue", 8);

        //string color = s.GetColor();
       // double area = s.GetArea();
        //Console.WriteLine($"The area of the {color} square is {area}");

        Rectangle r = new Rectangle("green", 27, 30);
        Circle c = new Circle("pink", 8.82);
        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The area of the {color} shape is {area}");

        }
    }
}