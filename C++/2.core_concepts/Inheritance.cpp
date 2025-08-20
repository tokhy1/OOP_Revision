#include <iostream>
#include <string>
using namespace std;

/**
 * Inheritance
------------------------
* Allows one class (derived) to reuse and extend another class (base).
* Establishes an “is-a” relationship.
* Promotes code reusability and extensibility.
* Types: Single, Multiple, Multilevel, Hierarchical, Hybrid.
* Access control depends on inheritance type (public, protected, private).
* Base class constructor runs before derived; destructors run in reverse order.
* Supports function overriding and polymorphism via virtual functions.

 * C++ specific gotchas in Inheritance
--------------------------
* In a class, members are private by default.
* If you don’t specify the inheritance type:
    - class Derived : Base → defaults to private inheritance.
    - Private inheritance: public & protected members of base become private in derived.
    - Protected inheritance: public & protected members of base become protected in derived.
* Public inheritance: preserves original access of base class members.
* Constructors of base classes are not inherited (but can be called explicitly in derived).
Destructors in base should be declared virtual if the class is meant to be inherited (to avoid resource leaks when deleting derived objects via base pointer).

*/

class Person
{
protected:
    string name;
    int age;

public:
    Person(string name, int age)
    {
        this->name = name;
        this->age = age;

        cout << "Parent class constructor" << endl;
    }

    // Class destructor assigned virtual to make sure that the child class destructor will be triggered.
    virtual ~Person() = default;

    void eat()
    {
        cout << "I eat food :)" << endl;
    }

    void drink()
    {
        cout << "I drink water :)" << endl;
    }
};

class Teacher : public Person
{
public:
    Teacher(string name, int age) : Person(name, age)
    {
        cout << "Child class constructor" << endl;
    }

    // Extended feature by child class
    void teach()
    {
        cout << "I can teach students" << endl;
    }

};

int main()
{
    // testing...
    Teacher teacher("Mohamed", 19);

    teacher.eat();
    teacher.drink();
    teacher.teach();

    return 0;
}
