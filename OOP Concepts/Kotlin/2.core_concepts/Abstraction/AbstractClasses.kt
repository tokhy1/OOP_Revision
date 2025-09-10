package oop_revesion

/*
An abstract class is a class that cannot be directly used to create objects (can't have instance from it).
It's meant to be inherited by other classes, which then must provide specific implementations for its abstract methods,
It's like a blueprint for other classes or a guidance for them to make them have necessary methods to implement.

Note that in Kotlin all abstract classes are open by default,
and abstract methods cannot have default implementations, but you can define concrete (normal) methods with implementation.
*/

abstract class Animal {
    // Abstract method (no implementation)
    abstract fun makeSound()

    /* Concrete method (implementation provided || default implementation)
    * If you want to override it in the subclass you have to make it open method
    */
    fun sleep() {
        println("The animal is sleeping")
    }
}

class Dog : Animal() {
    override fun makeSound() {
        println("Bark")
    }
}

fun main() {
    val dog = Dog()
    dog.makeSound() // Outputs: Bark
    dog.sleep()     // Outputs: The animal is sleeping
}
