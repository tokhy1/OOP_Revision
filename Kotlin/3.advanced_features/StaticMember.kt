package oop_revesion

/*
Static members in Kotlin are properties or functions that belong to a class itself,
not to instances of the class. They are shared across all instances.
We define them using 'companion object' in Kotlin.
*/

class BankAccount {
    // Regular instance property - each account has its own balance
    var balance: Double = 0.0

    companion object {
        // Static property - shared by all BankAccount instances
        // Tracks total number of accounts created
        var totalAccounts: Int = 0

        // Static constant - bank's interest rate, same for all accounts
        const val INTEREST_RATE = 0.05

        // Static function - can be called without creating an instance
        fun printBankInfo() {
            println("Total accounts: $totalAccounts")
            println("Current interest rate: ${INTEREST_RATE * 100}%")
        }
    }

    init {
        // Increment total accounts whenever a new instance is created
        totalAccounts++
    }
}

// Usage example:
fun main() {
    // Create instances
    val account1 = BankAccount()

    // Access static members using class name
    println(BankAccount.INTEREST_RATE)

    account1.balance = 100.0

    BankAccount.printBankInfo()
    println(account1.balance)
}