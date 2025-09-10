using c_.Basic_Concepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Abstraction:
 * Focuses on hiding implementation details and exposing only essential features.
 * Achieved using abstract classes or interfaces.

1. Abstract Classes:
 * Can contain both abstract (no body) and implemented methods.
 * Objects cannot be created from an abstract class.
 * Useful when you want to share code but also enforce unique implementations.
 * A class can inherit only one abstract class.

2. Interfaces:
 * Define a contract (methods/properties) without implementation.
 * A class can implement multiple interfaces.
 * All members of an interface must be implemented by the class.
*/



namespace c_.Core_Concepts
{
    // Abstract class example
    abstract class AnimalI
    {
        // Abstract method (must be implemented by derived classes)
        public abstract void MakeSound();

        // Normal method (shared behavior for all animals)
        public void Sleep()
        {
            Console.WriteLine("Zzz...");
        }
    }

    class DogI : AnimalI
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    class Cat : AnimalI
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    // Interface example
    interface Vehicle
    {
        void Start();
        void Stop();
    }

    class Car : Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Car is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Car is stopping...");
        }
    }
    class Boat: Vehicle
    {
        public void Start()
        {
            Console.WriteLine("boat is starting");
        }
        public void Stop()
        {
            Console.WriteLine("boat is stopping");
        }
    }

    class Abstraction
    {
        public static void DemoAbstraction()
        {
            // Abstract class usage
            AnimalI dog1 = new DogI();
            dog1.MakeSound();
            dog1.Sleep();

            AnimalI cat1 = new Cat();
            cat1.MakeSound();


            Vehicle myCar = new Car();

            myCar.Start();
            myCar.Stop();

            // Interface usage

            Vehicle myBoat = new Boat();
            myBoat.Start();
            myBoat.Stop();

        }
    }
}
