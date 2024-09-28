package oop_revesion

/*
In OOP we have two types of constructors (primary, secondary).

- Primary constructor: The primary constructor is a concise and direct way to initialize class properties.
    It is declared in the class header and does not contain code directly,
    but initialization logic can be added in an `init` block.
    It's ideal when all properties are known at the time of object creation.

- Secondary constructor: A secondary constructor provides an alternative way to initialize a class.
    It contains its own initialization logic and is useful when multiple constructors are needed,
    allowing the creation of objects in different ways or with more complex setups.
    Secondary constructors must delegate to the primary constructor if one exists.
    for making secondary constructors you can use `constructor` block.
*/

class Car(name: String, year: Int) {
    // primary constructor logic
    init {
        // this logic runs when any object is instantiated, even if there is a secondary constructor logic was created
        println("name is $name, year is $year")
    }

    // secondary constructor logic
    constructor(name: String) : this(name, 2022) {
        // here when you want to override constructors or perform different initialization logic
        // keep in mind that this logic runs after `init` logic
        println("name and year were printed above!")
    }
}


fun main() {
    val car1 = Car("tesla", 2019) // primary constructor
    val car2 = Car("BMW") // secondary constructor
}