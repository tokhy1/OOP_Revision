using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1. Inheritance
 * Inheritance allows a new class (child / derived class) to acquire
   properties and behaviors (fields and methods) from an existing class (base / parent class).
 * This promotes code reusability and extensibility — we don’t have to rewrite code that already exists.
 * When creating an object of a derived class, the constructor of the parent class executes first,
   followed by the constructor of the child class.

2. Access Modifiers
 * Access modifiers control the visibility (scope) of a class and its members.
 * In C#, there are 5 main access modifiers:
    - public: accessible anywhere
    - private: accessible only within the class where it is defined
    - protected: accessible within the class and any derived class
    - internal: accessible only within the same project/assembly
    - protected internal: accessible within the same project/assembly, and also by derived classes
*/

namespace c_.Core_Concepts
{
    class Animal
    {
        public string Name;               // public: can be accessed anywhere (the animal's name)
        private string HealthStatus;      // private: only the Animal itself knows (hidden from outside)
        protected string Sound;           // protected: child classes know how their animal sounds

        public Animal(string name, string Health, string Sound)
        {
            Name = name;
            HealthStatus = Health;
            this.Sound = Sound;
        }

        public void ShowHealth()
        {
            Console.WriteLine($"{Name}'s health status is: {HealthStatus}");
        }
    }


    // Derived class (Child)
    class Dog : Animal
    {
        public Dog(string name, string health) : base(name, health, "Woof Woof")
        //When you create a Dog, the Dog constructor must also call the Animal constructor (the parent).
        //This is done using the base(...) keyword.
        // name,health(parameters of dog constructor), "Woof Woof" are the arguments required for the constructor

        {
            Console.WriteLine("Dog created successfully.");
        }

        public void Bark()
        {
            // Can access Name (public) and Sound (protected), but not HealthStatus (private)
            Console.WriteLine($"{Name} says: {Sound}");
        }
    }

    class Inheritance
    {
        public static void DemoInheritance()
        {
            Dog dog1 = new Dog("Buddy", "Healthy");

            // Public method
            dog1.ShowHealth();

            // Derived class method
            dog1.Bark();

            // dog1.HealthStatus = 5; this will cause an error because it is private so accessible inside the Animal class only
            // dog1.Sound  = "Wolf"; will cause error because Sound is protected, cannot access here
        }

    }

}
