using System;

namespace InheritanceAndMethodOverriding
{
    // Base class Animal
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding Demo ===\n");

            // Create instances of Animal, Dog, and Cat
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call MakeSound() method on each instance
            Console.WriteLine("Animal makes sound:");
            animal.MakeSound();

            Console.WriteLine("\nDog makes sound:");
            dog.MakeSound();

            Console.WriteLine("\nCat makes sound:");
            cat.MakeSound();

            // Demonstrate polymorphism
            Console.WriteLine("\n=== Polymorphism Demo ===");
            Animal[] animals = { animal, dog, cat };
            
            for (int i = 0; i < animals.Length; i++)
            {
                Console.Write($"Animal {i + 1} makes sound: ");
                animals[i].MakeSound();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}