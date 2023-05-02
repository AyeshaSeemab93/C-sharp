// DO NOT TOUCH THIS FILE!
namespace Exercise001
{
    using System;

    public class Account  // class
    {

        public double balance { get; set; } // class attributes
        private string owner;

        public Account(string owner, double balance) // construct with paramaters(values will come from objects)
        {
            this.balance = balance; //saving parameter values to class attributes
            this.owner = owner;
        }
        //method1, called by object, it perform function for object
        public void Deposit(double amount) //saving amount in balance
        {
            this.balance = this.balance + amount;
        }
        //method2, called by object, it perform function for object
        public void Withdrawal(double amount) // taking out withdrawal money from balance
        {
            this.balance = this.balance - amount;
        }
        // method3 to return a string (to print a string)
        public override string ToString()
        {
            return this.owner + " balance: " + this.balance;
        }
    }
}
// DO NOT TOUCH THIS FILE!