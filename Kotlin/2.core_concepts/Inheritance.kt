package oop_revesion

/*
Inheritance in object-oriented programming is a mechanism where one class (subclass) inherits the attributes and behaviors (methods) from another class (superclass),
allowing for code reuse and the creation of a hierarchical relationship between classes.
The subclass can override or extend the functionalities of the superclass.

In Kotlin, inheritance is achieved using the open keyword, which marks a class as inheritable,
because by default, all classes in Kotlin are final (cannot be inherited).
Subclasses can override functions or properties from the parent class using the override keyword.
*/

// Parent class
open class Vehicle(val speed: Int) {
    open fun drive() {
        println("The vehicle is driving at $speed km/h.")
    }
}

// Child class: Bicycle
class Bicycle(speed: Int, val gear: Int) : Vehicle(speed) {
    // cannot use drive method from parent class without typing override keyword
    override fun drive() {
        println("The bicycle with $gear gears is riding at $speed km/h.")
    }
}


fun main() {
    val bicycle = Bicycle(30, 21)
    bicycle.drive()
}