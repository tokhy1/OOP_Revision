using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 1.polymorphism:
  * polymorphism is is greek word that means "many forms"
  * polymorphism let the same method behave differently based on the method
  * there is two ways to achieve i:
        -Run-time polymorphism (Method Overriding): it is redefining method 
                                                    using the same signiture but with different implementation
        -Compile-time polymorphism (Method Overloading): this means having multiple methods with the same name
                                                         but different parameters within the same class.

*/
namespace c_.Core_Concepts
{
    //actually we used polymorphism in abstraction when we defined the same method
    //of the abstract class in different ways(runtime polymorphism)
    //and we used it with constructors overloading(compile time polymorphism)


    // Base class
    class VehicleI
    {
        // Virtual method for runtime polymorphism
        public virtual void Failure()
        {
            Console.WriteLine("Call a specialist.");
        }

        // Overloaded method for compile-time polymorphism
        public void Drive()
        {
            Console.WriteLine("Driving vehicle...");
        }

        public void Drive(int speed)
        {
            Console.WriteLine($"Driving vehicle at {speed} km/h.");
        }
    }

    class CarI : VehicleI
    {
        public override void Failure()
        {
            Console.WriteLine("Call your mechanic.");
        }
    }

    class Bike : VehicleI
    {
        public override void Failure()
        {
            Console.WriteLine("Go home and fix it to avoid being injured.");
        }
    }

    class BoatI : VehicleI
    {
        public override void Failure()
        {
            base.Failure(); // Reusing base class implementation
            Console.WriteLine("Next time, learn the basics of fixing a boat to avoid danger.");
        }
    }

    class Polymorphism
    {
        public static void DemoPolymorphism()
        {
            // Runtime polymorphism (method overriding)
            VehicleI myCar = new CarI();
            VehicleI myBike = new Bike();
            VehicleI myBoat = new BoatI();

            myCar.Failure(); 
            myBike.Failure(); 
            myBoat.Failure(); 

            // Compile-time polymorphism (method overloading)
            VehicleI generalVehicle = new VehicleI();
            generalVehicle.Drive();  
            generalVehicle.Drive(80);

        }
    }

}
