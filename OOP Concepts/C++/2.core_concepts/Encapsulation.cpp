#include <iostream>
#include <string>
using namespace std;

/*
* Encapsulation in C++

Definition:
- Encapsulation is the principle of wrapping data (fields) and behavior (methods)
  into a single unit (class) and restricting direct access to the internal details.

Access control (using access specifiers):
- private   → Members accessible only inside the class (default in class).
- protected → Members accessible inside the class + derived (child) classes.
- public    → Members accessible from anywhere in the program.

Purpose:
- Hide internal implementation details.
- Control access to data.
- Prevent misuse and maintain data integrity.

Notes:
- Usually implemented with getters/setters to safely read or modify private members.

*/

class BankAccount
{
    // private by default
    double balance;

public:
    BankAccount(double balance)
    {
        cout << "New Account Created!" << endl;
        deposit(balance);
    }

    void deposit(double amount)
    {
        if (amount <= 0)
            throw invalid_argument("Invalid entry, please enter a valid balance to create your account");

        this->balance += amount;
    }

    void withdraw(double amount)
    {
        if (this->balance < amount || amount <= 0)
            throw invalid_argument("Invalid entry... ");

        this->balance -= amount;
    }

    void getBalance()
    {
        cout << "Your balance now is " << this->balance << endl;
    }
};

int main()
{
    BankAccount mohamed_account(100.00);

    mohamed_account.getBalance();
    mohamed_account.withdraw(50.0);
    mohamed_account.getBalance();
    mohamed_account.deposit(100);
    mohamed_account.getBalance();

    // mohamed_account.balance -> restricted cannot be accessed!

    return 0;
}
