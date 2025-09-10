#include <iostream>
#include <string>
using namespace std;

/**
 * Destructors vs Constructors in C++
 *
 * Constructor:
 * - Called when an object is created
 * - Can have multiple constructors (overloading)
 * - Can take parameters
 * - Same name as class with no return type
 *
 * Destructor:
 * - Called when an object is destroyed/goes out of scope
 * - Only one destructor per class
 * - Cannot take parameters
 * - Same name as class with ~ prefix
 * - Used to free resources/memory
 */

class Person
{
private:
    string name;
    int age;
    int *dynamicData; // Example of resource that needs cleanup

public:
    // Constructor
    Person(string n = "Unknown", int a = 0)
    {
        name = n;
        age = a;
        dynamicData = new int[5]; // Allocating dynamic memory
        cout << "Constructor called for: " << name << endl;
    }

    // Destructor
    ~Person()
    {
        cout << "Destructor called for: " << name << endl;
        delete[] dynamicData; // Cleaning up dynamic memory
    }

    // Member functions to display person info
    void displayInfo()
    {
        cout << "Name: " << name << ", Age: " << age << endl;
    }
};

int main()
{
    cout << "Creating first person object..." << endl;
    Person person1("John", 25);

    cout << "\nCreating second person object..." << endl;
    { // Creating a new scope
        Person person2("Alice", 30);
        cout << "Person2 will be destroyed when this scope ends" << endl;
    } // person2's destructor is called here

    cout << "\nProgram continuing..." << endl;
    person1.displayInfo();

    cout << "\nProgram ending, person1 will be destroyed" << endl;
    return 0; // person1's destructor is called here
}