package oop_revesion.access_modifires

fun main() {
    val myCar = Car("Sedan")
    myCar.start() // Accessible because start is public
    // myCar.showDetails() // Accessible because it's internal, and we're in the same module

    val myElectricCar = ElectricCar("Tesla")
    myElectricCar.drive() // Can access public and protected functions within the subclass
    println("Is the electric car running? ${myElectricCar.isRunning}")

    // Attempting to access private or protected members directly will cause errors:
    // println(myCar.engineNumber) // Error: engineNumber is private in Car
    // println(myCar.fuelLevel) // Error: fuelLevel is protected in Car
}
