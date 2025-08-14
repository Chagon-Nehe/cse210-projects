using System;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
        Shape sSquare = new Square("Red", 5);
        Shape sCircle = new Circle("Blue", 3);
        Shape sRectangle = new Rectangle("Green", 4, 6);
        //Console.WriteLine($"Square Color: {sSquare.GetColor()}, Area: {sSquare.CalculateArea()}");
        //Console.WriteLine($"Circle Color: {sCircle.GetColor()}, Area: {Math.Round(sCircle.CalculateArea(), 2)}");
        //Console.WriteLine($"Rectangle Color: {sRectangle.GetColor()}, Area: {sRectangle.CalculateArea()}");

        //creating a list of shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(sSquare);
        shapes.Add(sCircle);
        shapes.Add(sRectangle);
        
        //displaying the shapes and their areas
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {Math.Round(shape.CalculateArea(),2)}");
        }
    }
}