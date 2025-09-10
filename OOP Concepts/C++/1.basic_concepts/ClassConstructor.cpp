#include <iostream>
#include <string>
using namespace std;

/**
 * Constructors in C++
 *
 * In C++, we have two main ways to create constructors:
 *
 * 1. Default/Primary Constructor:
 *    - Basic constructor with no parameters
 *    - Initializes object with default values
 *    - Called automatically when object is created without parameters
 *
 * 2. Parameterized/Secondary Constructor:
 *    - Constructor with parameters
 *    - Allows custom initialization of object properties
 *    - Provides flexibility in object creation
 */

class Person
{
private:
    string name;
    int age;

public:
    // Default constructor
    Person()
    {
        name = "Unknown";
        age = 0;
        cout << "Default constructor called: " << name << ", age: " << age << endl;
    }

    // Parameterized constructor
    Person(string n, int a)
    {
        name = n;
        age = a;
        cout << "Parameterized constructor called: " << name << ", age: " << age << endl;
    }

    // Another parameterized constructor (demonstrating constructor overloading)
    Person(string n)
    {
        name = n;
        age = 18; // Default age
        cout << "Single parameter constructor called: " << name << ", default age: " << age << endl;
    }

    // Member functions to display person info
    void displayInfo()
    {
        cout << "Name: " << name << ", Age: " << age << endl;
    }
};

int main()
{
    // Creating objects using different constructors
    Person person1;             // Uses default constructor
    Person person2("John", 25); // Uses parameterized constructor
    Person person3("Alice");    // Uses single parameter constructor

    cout << "\nDisplaying person information:" << endl;
    person1.displayInfo();
    person2.displayInfo();
    person3.displayInfo();

    return 0;
}