#include <iostream>
#include <string>
using namespace std;

/*
* Enums in C++

Definition:
    A user-defined type consisting of a set of named integral constants.

Purpose:
    - Makes code more readable and self-documenting.
    - Prevents using "magic numbers".
    - C++11 introduced `enum class` (scoped enum) to avoid polluting the global namespace and improve type safety.
    - Default underlying type is `int`, but it can be explicitly defined.
*/

enum class Operation
{
    ADD,
    SUBTRACT,
    MULTIPLY
};

// Using scoped enum feature (EnumClass::enumValue)
int execute(Operation op, int a, int b)
{
    switch (op)
    {
    case Operation::ADD:
        return a + b;
    case Operation::SUBTRACT:
        return a - b;
    case Operation::MULTIPLY:
        return a * b;
    }
    return 0;
}

int main()
{
    int result = execute(Operation::MULTIPLY, 6, 10);
    cout << result << endl;

    return 0;
}
