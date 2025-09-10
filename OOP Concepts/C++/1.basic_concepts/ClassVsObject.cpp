// File: ClassVsObject.cpp
// Purpose: Demonstrates the concept of Classes and Objects in C++

#include <iostream>
#include <string>
using namespace std;

/*
CLASSES AND OBJECTS IN C++
-------------------------
1. CLASS:
    - A blueprint or template for creating objects
    - Defines properties (attributes) and behaviors (methods)
    - Example: Car class defines what every car should have

2. OBJECT:
    - An instance of a class
    - Contains real data and can perform actions
    - Example: myCar is a specific car with actual values

3. RELATIONSHIP:
    Class  -> Blueprint -> What a car should be
    Object -> Instance  -> Actual car you can drive
*/

// Class Definition
class Car
{
public:
    // Properties (also called attributes or member variables)
    string color;
    string name;

    // Methods (functions that belong to the class)
    void displayInfo()
    {
        cout << "Car Information:" << endl;
        cout << "Name: " << name << endl;
        cout << "Color: " << color << endl;
    }
};

int main()
{
    // Creating an object (instance) of the Car class
    Car myCar;

    // Setting object properties
    myCar.color = "red";
    myCar.name = "Ferrari";

    // Displaying car information using the method
    myCar.displayInfo();

    // Creating another object to show multiple instances
    Car friendsCar;
    friendsCar.color = "blue";
    friendsCar.name = "Toyota";
    friendsCar.displayInfo();

    return 0;
}