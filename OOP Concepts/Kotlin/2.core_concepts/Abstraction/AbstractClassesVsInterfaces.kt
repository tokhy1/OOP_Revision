package oop_revesion

/*
In simple terms, abstract classes are for when you have closely related objects that share some behavior but may also need to implement unique behavior.
Interfaces, on the other hand, are for defining common behavior that can be applied across completely unrelated objects,
giving more flexibility and allowing a class to take on multiple roles by implementing different interfaces.

Here's is a key differences between abstract classes and interfaces:-
+-------------------------+-------------------------+-------------------------+
|       Feature            |     Abstract Class      |         Interface        |
+-------------------------+-------------------------+-------------------------+
| Can have method          |      Yes                |      Yes (default in     |
| implementations          |  (Concrete methods)     |      some languages)     |
+-------------------------+-------------------------+-------------------------+
| Can have abstract        |      Yes                |      Yes (all methods    |
| methods                  |                         |      are abstract by     |
|                         |                         |      default in many     |
|                         |                         |      languages)          |
+-------------------------+-------------------------+-------------------------+
| Can have fields (state)  |      Yes                |      No (cannot have     |
|                         |                         |      instance variables) |
+-------------------------+-------------------------+-------------------------+
| Can have constructors    |      Yes                |      No (no constructors)|
+-------------------------+-------------------------+-------------------------+
| Multiple inheritance     |      No                 |      Yes (a class can    |
|                          |                         |      implement multiple  |
|                          |                         |      interfaces)         |
+-------------------------+-------------------------+-------------------------+
| Best for:                |      Classes that are   |      Defining capabilities|
|                          |      closely related    |      or behaviors across |
|                          |      and need shared    |      unrelated classes   |
|                          |      state/behavior     |      (like Flyable,      |
|                          |                         |      Drivable)           |
+-------------------------+-------------------------+-------------------------+
| Flexibility              |      Limited to single  |      Highly flexible     |
|                          |      inheritance        |      due to multiple     |
|                          |                         |      interface support   |
+-------------------------+-------------------------+-------------------------+

Note that in many languages (like Java), an interface can only declare abstract methods (though Kotlin allows default method implementations).
*/

// Example of using both interfaces and abstract classes together:-

// Interface representing the ability to process payments
interface PaymentProcessor {
    fun processPayment(amount: Double): String
}

// Abstract class providing some shared behavior and methods
abstract class OnlinePayment : PaymentProcessor {
    // Shared method for online payments
    fun validatePaymentDetails(): Boolean {
        return true // Assuming validation is successful for example
    }
}

// Concrete class for Credit Card payment
class CreditCardPayment : OnlinePayment() {
    override fun processPayment(amount: Double): String {
        // Additional credit card-specific logic can be added here
        validatePaymentDetails()
        return "Credit Card payment of $$amount processed."
    }
}

// Concrete class for PayPal payment
class PayPalPayment : OnlinePayment() {
    override fun processPayment(amount: Double): String {
        // Additional PayPal-specific logic can be added here
        validatePaymentDetails()
        return "PayPal payment of $$amount processed."
    }
}

fun main() {
    val creditCardPayment: PaymentProcessor = CreditCardPayment()
    println(creditCardPayment.processPayment(100.0))

    val paypalPayment: PaymentProcessor = PayPalPayment()
    println(paypalPayment.processPayment(50.0))
}
