#include <iostream>
#include <string>
using namespace std;

/*
* Abstraction in C++

Definition:
    Hiding the internal implementation details of a class
    and exposing only essential features.

Achieved by:
    - Abstract classes (classes with at least one pure virtual function)
    - Interfaces (in C++ implemented via classes with only pure virtual functions)

Purpose:
    - Defines a common interface for different implementations.
    - Forces derived classes to implement specific behaviors.

Pure virtual function syntax example:
    virtual void func() = 0;

Note:
    Abstract classes cannot be instantiated directly.
    There is no `abstract` keyword, abstract class in C++ is the class that has at least one pure virtual function.
    There is no interface in c++, the main reason is this language supports multiple inheritance, so if wanna apply abstraction you can use abstract class.
*/

// Abstract class
class IShape
{
public:
    virtual void draw() = 0;
    virtual double area() = 0;
    virtual ~IShape() {} // virtual destructor
};

// In concrete classes if you didn't implement `all` pure virtual methods, this class will be abstract class
class Circle : public IShape
{
private:
    double radius;

public:
    Circle(double r)
    {
        this->radius = r;
    }

    void draw() override
    {
        cout << "Drawing a circle using a radius: " << radius << endl;
    }

    double area() override
    {
        return 3.14159 * radius * radius;
    }
};

class Square : public IShape
{
private:
    double dimension;

public:
    Square(double dim)
    {
        dimension = dim;
    }

    void draw() override
    {
        cout << "Drawing a square by a dimension: " << dimension << endl;
    }

    double area() override
    {
        return dimension * dimension;
    }
};

int main()
{
    IShape *shapes[2];
    shapes[0] = new Circle(4);
    shapes[1] = new Square(4);

    for (IShape *shape : shapes)
    {
        shape->draw();
        cout << shape->area() << endl;
        delete shape;
    }

    return 0;
}
