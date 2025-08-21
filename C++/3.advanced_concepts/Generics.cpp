#include <iostream>
#include <string>
using namespace std;

/*
* Generics in C++ (Templates)

Definition:
    Allows you to write classes or functions that work with any data type without rewriting code.

Purpose:
    - Promotes code reuse.
    - Provides type safety while avoiding duplication.
    - C++ equivalent of “generics” is called templates.

Types of templates:
    - Function templates  → generic functions.
    - Class templates     → generic classes.
*/

#include <iostream>
using namespace std;

// Generic class to hold a value
template <typename T>
class Box
{
private:
    T value;

public:
    Box(T val)
    {
        value = val;
    }

    void display() const
    {
        cout << "Value: " << value << endl;
    }
};

int main()
{
    Box<int> intBox(123);
    intBox.display();

    Box<string> strBox("Hello");
    strBox.display();
}
