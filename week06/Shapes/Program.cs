using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        

        Square s = new Square("blue", 10);
        
        string color = s.GetColor();
        double area = s.GetArea();
        Console.WriteLine($"The area of the {color} square is {area}");
    }
}