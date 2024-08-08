using System;

namespace AbstractClasses
{
    internal class Program
    {
        // Step 1: Create an abstract class
        public abstract class Shape
        {
            // Abstract Methods to be implemented by derived classes
            public abstract double CalculateArea();
            public abstract double CalculatePerimeter();
        }

        // Step 2: Create derived class for Circle
        public class Circle : Shape
        {
            // Property for Circle's radius
            public double Radius { get; set; }

            // Constructor to initialize the radius
            public Circle(double radius)
            {
                Radius = radius;
            }

            // Implement abstract method to calculate area
            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }

            // Implement abstract method to calculate perimeter
            public override double CalculatePerimeter()
            {
                return 2 * Math.PI * Radius;
            }
        }

        // Step 3: Create derived class for Rectangle
        public class Rectangle : Shape
        {
            // Properties for Rectangle's width and height
            public double Width { get; set; }
            public double Height { get; set; }

            // Constructor to initialize width and height
            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            // Implement abstract method to calculate area
            public override double CalculateArea()
            {
                return Width * Height;
            }

            // Implement abstract method to calculate perimeter
            public override double CalculatePerimeter()
            {
                return 2 * (Width + Height);
            }
        }

        // Step 4: Implement the Main method
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            // Calculate and display the area and perimeter of the Circle
            Console.WriteLine("Circle Area: " + circle.CalculateArea());
            Console.WriteLine("Circle Perimeter: " + circle.CalculatePerimeter());

            // Calculate and display the area and perimeter of the Rectangle
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
            Console.WriteLine("Rectangle Perimeter: " + rectangle.CalculatePerimeter());
        }
    }
}
