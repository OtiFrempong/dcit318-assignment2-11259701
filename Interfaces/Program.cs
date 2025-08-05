using System;

namespace Interfaces
{
    // Interface IMovable
    public interface IMovable
    {
        void Move();
    }

    // Class Car implementing IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle implementing IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interfaces Demo ===\n");

            // Create instances of Car and Bicycle
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            // Call Move() method on each instance
            Console.WriteLine("Car movement:");
            car.Move();

            Console.WriteLine("\nBicycle movement:");
            bicycle.Move();

            // Demonstrate polymorphism with interface
            Console.WriteLine("\n=== Polymorphism with Interface ===");
            IMovable[] movables = { car, bicycle };
            
            for (int i = 0; i < movables.Length; i++)
            {
                Console.Write($"Movable object {i + 1}: ");
                movables[i].Move();
            }

            // Demonstrate interface as parameter
            Console.WriteLine("\n=== Interface as Parameter ===");
            MoveObject(car);
            MoveObject(bicycle);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method that accepts any object implementing IMovable
        static void MoveObject(IMovable movable)
        {
            Console.Write("Moving object: ");
            movable.Move();
        }
    }
}