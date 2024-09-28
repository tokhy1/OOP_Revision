package oop_revesion

/*
Enums are a special type of class used to define a limited set of fixed values.
Each value in an enum is a constant, and they help make your code more readable and prevent mistakes by ensuring that only the predefined values are used.
Use enums when you have a small number of related constants, like days of the week, directions, or categories.

So, in summary they are used when dealing with special data types have certain options or choices like (days of week, directions, etc...)
*/

enum class Direction {
    // each option represents an instance of the class
    NORTH, SOUTH, EAST, WEST;

    fun navigate(direction: Direction) {
        when (direction) {
            NORTH -> println("Heading North")
            SOUTH -> println("Heading South")
            EAST -> println("Heading East")
            WEST -> println("Heading West")
        }
    }
}

fun main() {
    val direction = Direction.NORTH
    direction.navigate(direction) // navigating to North!
}