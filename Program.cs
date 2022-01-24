using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IHasArea>();
            shapes.Add(new Square(5));
            shapes.Add(new Triangle(12, 6));
            shapes.Add(new Square(100));
            shapes.Add(new Square(.1234M));
            shapes.Add(new Triangle(33, 44));
            shapes.Add(new Circle(5));
            shapes.Add(new Circle(10));

            foreach (var shape in shapes)
            {
                Console.WriteLine($"The area of this {shape.Name} is {shape.CalculateArea()}");

            }
        }
    }


}