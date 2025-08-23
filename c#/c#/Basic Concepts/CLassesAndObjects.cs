using System;

/*
1. Classes:
 * A class is a blueprint for creating objects.
 * It is like a template that defines the fields, properties, and methods of a real-world object.
 * For example, every Car has a color, number of doors, model, etc. — these are defined in the class.

2. Objects:
 * An object is an instance of a class.
 * It contains actual data about a specific thing.
 * Using the same example, every car has its own unique color, number of doors, model, etc.
   So when we create an object from the Car class, that object represents a real car with specific properties.
*/

namespace c_.Basic_Concepts
{
    class Car
    {
        //here we will create Fields(characteristics of the car) and methods that any car can have
        public string brand;
        public int numOfDoors;
        public string color;
        public int model;

        public void describe()
        {
            Console.WriteLine($"This car is a {color} {brand} ({model}) with {numOfDoors} doors.");
        }

        public void start()
        {
            Console.WriteLine("Vrooom! The car has started, you can move now.");
        }
    }

    class CLassesAndObjects
    {
        public static void DemoClassesAndObjects()
        {
            // Creating objects from the Car class
            Car car1 = new Car();
            car1.brand = "Toyota";
            car1.numOfDoors = 4;
            car1.color = "Red";
            car1.model = 2020;

            Car car2 = new Car();
            car2.brand = "BMW";
            car2.numOfDoors = 2;
            car2.color = "Black";
            car2.model = 2023;

            // Calling methods on objects
            car1.describe();
            car1.start();
            car2.describe();
            car2.start();
        }
    }
}
