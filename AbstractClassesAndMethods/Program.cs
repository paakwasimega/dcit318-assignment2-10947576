using System;

namespace AbstractClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Console.WriteLine($"Circle Area: {circle.GetArea()}"); // Output: Circle Area: 78.53981633974483

            Shape rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}"); // Output: Rectangle Area: 24
        }
    }
}
