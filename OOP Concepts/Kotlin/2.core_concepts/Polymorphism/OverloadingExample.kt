package oop_revesion

/*
In object-oriented programming (OOP), overloading refers to defining multiple methods with the same name within the same class but with different parameter lists (varying in type, number, or order of parameters).
This allows the same method name to perform different tasks based on the arguments provided, enhancing code readability and flexibility.
*/

class Printer {
    fun print(value: String) {
        println("Printing string: $value")
    }

    fun print(value: Int) {
        println("Printing integer: $value")
    }
}

fun main() {
    val printer = Printer()
    printer.print("Hello")  // Output: "Printing string: Hello"
    printer.print(123)      // Output: "Printing integer: 123"
}