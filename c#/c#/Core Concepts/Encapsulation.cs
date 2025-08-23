using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Encapsulation:
 * - Hides the internal state of an object and protects it from unauthorized access or unintended modification.
 * - Achieved by making fields private and exposing them through properties (getters and setters).
 * - This ensures controlled access and maintains data integrity.
 *
 * Properties vs Fields:
 * - Field: A variable declared inside a class that directly holds data (usually kept private).
 * - Property: A special member that provides controlled access to a field through get and set.
 *   -> get  : used to read the value of a field.
 *   -> set  : used to assign a value to a field (with optional validation).
 * 
 * Benefits of Encapsulation:
 * 1. Control → You decide how data is set or retrieved (validation, restrictions).
 * 2. Security → Internal data cannot be accessed directly.
 * 3. Flexibility → Implementation can change without affecting external code.
 * 4. Reusability & Maintainability → Cleaner and safer code design.
 */

namespace c_.Core_Concepts
{
    class BankAccount
    {
        // Private field (cannot be accessed directly from outside)
        private decimal balance;

        // Property with getter and setter
        public decimal Balance
        {
            get { return balance; } // getter → allows reading balance
            private set             // setter → restricted to inside class only
            {
                if (value >= 0)     // ensures no negative balance
                    balance = value;
            }
        }

        // Methods to work with balance
        public void Deposit(decimal amount)
        {
            if (amount > 0)
                Balance += amount; // uses property instead of directly changing field
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
                Balance -= amount;
        }
    }


    class Encapsulation
    {
        public static void DemoEncapsulation()
        {
            BankAccount account = new BankAccount();

            // Deposit money
            account.Deposit(500);
            Console.WriteLine("Balance after deposit: " + account.Balance);

            // Withdraw money
            account.Withdraw(200);
            Console.WriteLine("Balance after withdrawal: " + account.Balance);
            
            //account.Balance = -100; // Not allowed because setter is private

        }
    }
}
