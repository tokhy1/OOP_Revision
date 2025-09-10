package oop_revesion.access_modifires

/*
In simple terms, access modifiers in Kotlin control the visibility and accessibility of classes and members.
They define who can access specific parts of code, helping manage encapsulation and security. Here’s a summary:
- public: Accessible from anywhere.
- private: Accessible only within the containing class or file.
- protected: Accessible within the containing class and its subclasses.
- internal: Accessible within the same module only.
*/

// An example covers all access modifiers

// `internal` class, accessible within the same module
internal open class Car(private val model: String) {

    // `public` property, accessible from anywhere
    public var isRunning: Boolean = false

    // `private` property, accessible only within Car class
    private val engineNumber: String = "ENG123456"

    // `protected` property, accessible in subclasses
    protected open val fuelLevel: Int = 100

    // `public` function, accessible from anywhere
    public fun start() {
        isRunning = true
        println("$model is starting.")
    }

    // `internal` function, accessible within the same module
    internal fun showDetails() {
        println("Car model: $model, Engine number: $engineNumber, Fuel level: $fuelLevel%")
    }

    // `protected` function, accessible in subclasses
    protected fun consumeFuel() {
        println("Fuel is being consumed.")
    }
}

// A subclass of Car that demonstrates `protected` access
internal class ElectricCar(model: String) : Car(model) {

    // Override protected member
    override val fuelLevel: Int = 80 // Can access and override the protected property

    // Public function to demonstrate access to protected members
    fun drive() {
        start()
        consumeFuel()
        println("Electric car is driving with $fuelLevel% battery.")
    }
}
