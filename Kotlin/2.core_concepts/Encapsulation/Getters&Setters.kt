package oop_revesion
/*
By default, in Kotlin, when you create a variable (property) inside a class,
Kotlin automatically defines default getter and setter methods for this property.

- Getter methods allow you to retrieve or "get" the value of an object's property.
    They provide a way to access the private data of an object from outside the class.

- Setter methods allow you to modify or "set" the value of an object's property.
    They help in controlling how the internal state of an object is changed,
    often including validation before updating the property.

For example, if you declare a property without custom getter or setter,
Kotlin will use default implementations that simply return or assign the value of the property.

class Person {
    var name: String = "John Doe" // Default getter returns the value, default setter assigns a new value
}
*/

class Person {

    /*
        Interesting fact: In Kotlin, a "field" refers to the backing storage of a property.
        When a property is declared in a class, Kotlin automatically creates a private backing field to store the property's value.
        You can use the `field` keyword within custom getters and setters to refer to this backing field.
    */
    var name: String = ""
        get() = field.uppercase() // Custom getter returns the name in uppercase
        set(value) {
            // Custom setter checks if the value not equals "test"
            field = if (value != "test") value else "invalid input"
        }

    var age: Int = 20
        private set // This makes the setter private, allowing read-only access
}

fun main() {
    val person = Person()
    person.name = "test"
    println(person.name) // INVALID INPUT
    println(person.age) // 20
}
