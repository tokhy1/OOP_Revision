#include <iostream>
#include <string>
using namespace std;

/*
* Polymorphism in C++

Definition:
- Ability of different classes to respond differently to the same function call.

Types:
1. Compile-time (static)
    - Achieved by function overloading & operator overloading.

2. Runtime (dynamic)
    - Achieved by virtual functions and method overriding.
    - Key requirement: At least one function in the base class must be marked as virtual.

Destructor Note:
- Base class destructor should be virtual if used polymorphically.

Benefit:
- Promotes flexibility and extensibility (one interface, many implementations).
*/


// system notification treated as a base class.
class Notifier
{
protected:
    string message;

public:
    Notifier(string message)
    {
        cout << "New Notification will be created" << endl;
        this->message = message;
    }

    virtual void sendNotification()
    {
        cout << "Sending a system notification: " << message << endl;
    }
};

class EmailNotifier : public Notifier
{
public:
    EmailNotifier(string message) : Notifier(message)
    {
        cout << "Notification type specified to be Email Notification" << endl;
    }

    void sendNotification() override
    {
        cout << "Sending an email notification: " << message << endl;
    }
};

class SmsNotifier : public Notifier
{
public:
    SmsNotifier(string message) : Notifier(message)
    {
        cout << "Notification type specified to be Sms Notification" << endl;
    }

    void sendNotification() override
    {
        cout << "Sending an sms notification: " << message << endl;
    }
};

int main()
{
    Notifier *notifications[2];
    notifications[0] = new EmailNotifier("Congrats! You got the internship!");
    notifications[1] = new SmsNotifier("Extend your WIFI with 20GB extra for 100EGB");

    for (Notifier *n : notifications)
    {
        n->sendNotification(); // Polymorphism in action
    }

    for (Notifier *n : notifications)
    {
        delete n; // clean up
    }

    return 0;
}
