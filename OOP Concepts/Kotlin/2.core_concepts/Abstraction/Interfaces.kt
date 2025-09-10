package oop_revesion

/*
An interface in OOP is a contract that defines methods and properties that a class must implement,
allowing multiple classes to share common functionality without dictating how they implement it.
It's like a guidance for defining the way of how methods in the classes will be implemented.

Note: in most languages in interface you cannot define a default implementation for a method, but in kotlin you can define the implementation.
*/

// Defining an interface
interface Drivable {
    fun drive() // Method without implementation
    // Method with implementation
    fun park() {
        println("Vehicle is parking")
    }
    val speed: Int // Property without implementation
}

// Class Car implements the Drivable interface
class Bus : Drivable {
    override val speed: Int = 100
    override fun drive() {
        println("Bus is driving at speed $speed km/h")
    }
}

// Class Bike implements the Drivable interface
class Bike : Drivable {
    override val speed: Int = 30
    override fun drive() {
        println("Bike is driving at speed $speed km/h")
    }
    // Overriding the default implementation for the method
    override fun park() {
        println("Bike is parking")
    }
}

fun main() {
    val myBus: Drivable = Bus()
    myBus.drive() // Outputs: Bus is driving at speed 100 km/h
    myBus.park() // Outputs: Vehicle is parking

    val myBike: Drivable = Bike()
    myBike.drive() // Outputs: Bike is driving at speed 30 km/h
    myBike.park() // Outputs: Bike is parking
}
