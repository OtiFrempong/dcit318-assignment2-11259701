using System;

namespace AbstractClassesAndMethods
{
    // Abstract base class Shape
    public abstract class Shape
    {
        public abstract double GetArea();
        
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Area: {GetArea():F2}");
        }
    }

    // Derived class Circle
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Circle with radius {radius}:");
            base.DisplayInfo();
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Rectangle with length {length} and width {width}:");
            base.DisplayInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods Demo ===\n");

            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display areas
            circle.DisplayInfo();
            Console.WriteLine();
            rectangle.DisplayInfo();

            // Demonstrate polymorphism with abstract class
            Console.WriteLine("\n=== Polymorphism with Abstract Class ===");
            Shape[] shapes = { circle, rectangle };
            
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.Write($"Shape {i + 1} - ");
                shapes[i].DisplayInfo();
            }

            // Show that we cannot instantiate abstract class
            Console.WriteLine("\n=== Note ===");
            Console.WriteLine("Cannot create instance of abstract class Shape:");
            Console.WriteLine("// Shape shape = new Shape(); // This would cause compilation error");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}