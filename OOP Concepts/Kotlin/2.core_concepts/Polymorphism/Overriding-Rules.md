# Overriding Rules in Object-Oriented Programming

Overriding rules are general in OOP for most of Programming languages, and they exist to ensure consistency, clarity, and safety when modifying inherited behavior in object-oriented programming (OOP). They prevent confusion and errors by establishing clear guidelines for how and when methods can be redefined in subclasses, maintaining compatibility between classes.

> When it comes to overriding, you cannot restrict the behavior of the parent class, but you can extend it (e.g., visibility, mutability, etc.).

<br>

**Examples of Key Overriding Rules:**

## 1. Same Method Signature

The overridden method in the subclass must have the **same name, return type, and parameters** as the method in the superclass. If the method signature differs, it is considered **overloading**, not overriding.

Example:

```kotlin
open class Animal {
    open fun makeSound() {
        println("Animal sound")
    }
}

class Dog : Animal() {
    override fun makeSound() {  // Correct overriding
        println("Woof")
    }

    fun makeSound(intensity: String) {  // This is overloading, not overriding
        println("Woof $intensity")
    }
}
```

## 2. Access Modifiers

The access level of the overriding method cannot be **more restrictive** than that of the method in the superclass.

Example:

```kotlin
open class Animal {
    protected open fun eat() {
        println("Animal is eating")
    }
}

class Dog : Animal() {
    public override fun eat() {  // Correct: public is less restrictive than protected
        println("Dog is eating")
    }
}

class Cat : Animal() {
    private override fun eat() {  // Incorrect: private is more restrictive than protected
        println("Cat is eating")
    }
}
```

## 3. Return Type

The return type of the overriding method should be either the **same** as the overridden method or a **subclass** of the return type in the overridden method (covariant return type).

Example:

```kotlin
open class Shape {
    open fun getShape(): Shape {
        return Shape()
    }
}

class Circle : Shape() {
    override fun getShape(): Circle {  // Correct: Circle is a subclass of Shape
        return Circle()
    }
}
```

## 4. Using the `override` Keyword

In Kotlin, the `override` keyword is mandatory when overriding a method.

Example:

```kotlin
open class Animal {
    open fun makeSound() {
        println("Animal sound")
    }
}

class Dog : Animal() {
    override fun makeSound() {
        println("Woof")
    }
}
```

## 5. Method Cannot Be More Specific

The overriding method cannot throw more exceptions than the overridden method unless they are unchecked exceptions.

Example:

```kotlin
import java.io.IOException
import java.sql.SQLException

open class Animal {
    @Throws(IOException::class)
    open fun eat() {
        // Implementation
    }
}

class Dog : Animal() {
    @Throws(IOException::class)
    override fun eat() {  // Correct
        // Implementation
    }
}

class Cat : Animal() {
    @Throws(IOException::class, SQLException::class)
    override fun eat() {  // Incorrect: throws more checked exceptions
        // Implementation
    }
}
```

## 6. Calling the Superclass Method

In the subclass, you can call the superclass's version of the method using `super.methodName()`.

Example:

```kotlin
open class Animal {
    open fun makeSound() {
        println("Animal sound")
    }
}

class Dog : Animal() {
    override fun makeSound() {
        super.makeSound()  // Call the superclass method
        println("Woof")
    }
}
```

## 7. Final Methods Cannot Be Overridden

If a method in the superclass is marked as `final`, it cannot be overridden in any subclass. In Kotlin, methods are `final` by default.

Example:

```kotlin
open class Animal {
    fun breathe() {  // final by default
        println("Animal breathing")
    }
}

class Dog : Animal() {
    override fun breathe() {  // Compilation error: Cannot override final method
        println("Dog breathing")
    }
}
```

## 8. Static Methods and Overriding

In Kotlin, static methods are typically defined as companion object functions. They cannot be overridden because they belong to the class, not to instances of the class.

Example:

```kotlin
open class Animal {
    companion object {
        fun classify() {
            println("This is an animal")
        }
    }
}

class Dog : Animal() {
    companion object {
        fun classify() {  // This is a new method, not an override
            println("This is a dog")
        }
    }
}
```

## 9. Private Methods Cannot Be Overridden

Private methods are not inherited by subclasses, so they cannot be overridden.

Example:

```kotlin
open class Animal {
    private fun sleep() {
        println("Animal sleeping")
    }
}

class Dog : Animal() {
    private fun sleep() {  // This is a new method, not an override
        println("Dog sleeping")
    }
}
```

## 10. Constructors Cannot Be Overridden

Constructors are not methods and thus cannot be overridden. However, a subclass can invoke the superclass constructor.

Example:

```kotlin
open class Animal {
    init {
        println("Animal constructor")
    }
}

class Dog : Animal() {
    init {
        println("Dog constructor")
    }
}
```

## 11. Constructor `var` vs `val` Rule

When a parent class defines a constructor parameter as `var`, a subclass cannot override that parameter with `val`.

Example:

```kotlin
open class Animal(var name: String)

class Dog(name: String) : Animal(name)  // Correct
// class Dog(val name: String) : Animal(name)  // Error: Can't override var with val
```

## 12. Interface and Parent Class Method Conflict

If a parent class and an interface both declare a method with the same signature, the subclass is required to explicitly override the method.

Example:

```kotlin
interface Sound {
    fun makeSound() {
        println("Default sound from interface")
    }
}

open class Animal {
    open fun makeSound() {
        println("Sound from Animal class")
    }
}

class Dog : Animal(), Sound {
    override fun makeSound() {  // Required to resolve ambiguity
        super<Animal>.makeSound()  // Choose implementation from Animal class
    }
}

fun main() {
    val dog = Dog()
    dog.makeSound()  // Output: Sound from Animal class
}
```
