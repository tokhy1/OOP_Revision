package oop_revesion

/*
- Class: A class is used to define or describe something from the real world in a program.
    For example, think of a car. In code, we can create a class called Car to describe what a car is — like
    its color, speed, and type of engine. The class also describes what a car can do, like drive or stop.

- Object: An object is an instance of a class — meaning it’s the actual thing created from the class blueprint.
    If the class is like the definition of a car, then an object is a specific car in real life. For example,
    if we have a class Car, we can create objects like myCar or yourCar,
    each with its own specific details, like "red" for the color or "150 km/h" for the speed.

- Difference: A class defines the general idea of something,
    and an object is the real version of that thing with specific properties.

*/


// defining class
class Example {
    // defining variables/properties for the class
    var name: String = ""
}


fun main() {
    // defining object
    val example = Example()
    example.name = "First Example"
    println(example.name)
}