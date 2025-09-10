package oop_revesion

/*
Generics are a programming concept that allows you to write classes, interfaces, and functions that can work with different data types while maintaining type safety at compile time.
They act like type placeholders, letting you write code once and use it with various types, avoiding code duplication and redundant type casting.
Think of them as writing code that works like a container that can hold any type - similar to how a box can hold different items while keeping them organized and safe.
*/

// Generic class example
// <T> is a type parameter - it can be any valid type (String, Int, CustomClass, etc.)
class Box<T>(var content: T) {
    // test implementation to work with generic type

    fun getContent(): T {
        return content
    }

    fun setContent(newContent: T) {
        content = newContent
    }
}

// Generic function example
// This function can swap any two items of the same type
fun <T> swapItems(array: Array<T>, index1: Int, index2: Int) {
    val temp = array[index1]
    array[index1] = array[index2]
    array[index2] = temp
}

// Example with type constraints
// <T : Number> means T must be Number or its subclass (Int, Double, etc.)
class NumberProcessor<T : Number> {
    fun square(input: T): Double {
        return input.toDouble() * input.toDouble()
    }
}

// Usage example:
fun main() {
    // Using Box with different types
    val stringBox = Box("Hello")              // Box<String>
    val intBox = Box(42)                      // Box<Int>

    // Using generic function
    val numbers = arrayOf(1, 2, 3, 4)
    swapItems(numbers, 0, 3)                  // Works with Int array

    val words = arrayOf("apple", "banana")
    swapItems(words, 0, 1)                    // Works with String array

    // Using constrained type
    val processor = NumberProcessor<Int>()
    println(processor.square(5))              // Works with Numbers only
}