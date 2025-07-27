using System;

namespace OOP_Principles
{
    // Abstraction & Encapsulation
    public class BankAccount
    {
        private double balance; // Encapsulated field

        public string AccountHolder { get; set; }

        public BankAccount(string holder, double initialBalance)
        {
            AccountHolder = holder;
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Insufficient funds or invalid amount.");
        }

        public double GetBalance()
        {
            return balance;
        }
    }

    // Inheritance
    public class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string holder, double initialBalance, double interestRate)
            : base(holder, initialBalance)
        {
            InterestRate = interestRate;
        }

        // Polymorphism - method overriding
        public void AddInterest()
        {
            Deposit(GetBalance() * InterestRate / 100);
        }
    }

    class Program
    {
        static void Main()
        {
            // Create SavingsAccount object
            SavingsAccount account = new SavingsAccount("Anirudh", 1000.0, 5.0);

            account.Deposit(500);
            account.Withdraw(200);
            account.AddInterest(); // Uses overridden behavior

            Console.WriteLine($"Account Holder: {account.AccountHolder}");
            Console.WriteLine($"Final Balance: {account.GetBalance()}");

            // Polymorphism - same method name behaves differently in different class
            BankAccount baseAccount = new BankAccount("krishna", 800);
            baseAccount.Deposit(100);
            Console.WriteLine($"Base Account Balance: {baseAccount.GetBalance()}");
        }
    }
}
