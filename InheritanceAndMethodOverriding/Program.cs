using System;

namespace InheritanceAndMethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.MakeSound(); // Output: Some generic sound

            Dog dog = new Dog();
            dog.MakeSound(); // Output: Bark

            Cat cat = new Cat();
            cat.MakeSound(); // Output: Meow
        }
    }
}
