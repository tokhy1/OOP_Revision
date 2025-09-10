using System;

/*
* Enums in C#
*
* Definition:
*     A distinct value type that consists of a set of named integral constants.
*
* Purpose:
*     - Makes code more readable and self-documenting.
*     - Prevents using "magic numbers".
*     - Provides type-safety (enums are strongly typed in C#).
*     - Default underlying type is int, but it can be explicitly defined (e.g., byte, short, long).
*     - Can be decorated with attributes (e.g., [Flags]) for bitwise combinations.
*/


namespace c_.Advanced_Concepts
{
    enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    class Calculator
    {
        public static int Execute(Operation op, int a, int b)
        {
            switch (op)
            {
                case Operation.Add:
                    return a + b;
                case Operation.Subtract:
                    return a - b;
                case Operation.Multiply:
                    return a * b;
                case Operation.Divide:
                    if (b == 0)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        return 0;
                    }
                    return a / b;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }
    }

    class EnumsClass
    {
        public static void DemoEnums()
        {
            int result = Calculator.Execute(Operation.Multiply, 6, 10);
            Console.WriteLine($"Result: {result}"); // Output: Result: 60
        }
    }

}