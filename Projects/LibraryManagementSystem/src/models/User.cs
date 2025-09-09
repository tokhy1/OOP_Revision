using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    public abstract class User
    {
        public string Name { get; private set; } // it doesn't make sense to change my name right?
        public string Email { get; protected set; }
        public int Age { get; protected set; }
        public string PhoneNumber { get; protected set; }

        public User(string name, string email, int age, string phoneNumber)
        {
            // basic validation
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty");
            if (age <= 0)
                throw new ArgumentException("Age must be positive");
            if (!email.Contains("@"))
                throw new ArgumentException("Invalid email format");

            Name = name;
            Email = email;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        public virtual string GetDetails()
        {
            return $"{Name}, {Age} years old, Email: {Email}, Phone: {PhoneNumber}";
        }
    }
}