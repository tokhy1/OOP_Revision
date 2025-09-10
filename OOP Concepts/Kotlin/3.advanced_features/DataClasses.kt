package oop_revesion

/*
A data class in Kotlin is a class specifically created to store and manage data.
It automatically generates common functionality such as checking if two objects are the same based on their content,
printing their values in a readable way, and allowing you to easily copy them with modifications.
Data classes make it easy to handle simple data structures like records or models with minimal code.

So, in summary they are used in cases of Dealing with states, Representing data and Holding data.
*/

// Note that data classes can have the same properties of normal classes (properties, methods, etc...)
data class Book(val title: String, val author: String, val price: Int)

fun main() {
    val book1 = Book("Best Habit", "Nicola Tesla", 1500)
    val book2 = Book("Best Habit", "Nicola Tesla", 1500)

    // testing
    println(book1)
    println(book2 == book1) // true

    // destructing feature in data classes
    val (title, author, price) = book2
    println("title: $title, author: $author, price: $price")
    println(book2.component1())
}
