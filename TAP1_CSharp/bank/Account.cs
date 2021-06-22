using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    public class Account
    {
        protected double balance;
        private Customer owner;
        protected double interest;
        public void setInterest(double interest)
        {
            this.interest = interest;
        }


        public Account(double balance, Customer owner)
        {
            this.balance = balance;
            this.owner = owner;
        }

        public void deposit(double amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
                throw new NoMoney("No money enough");
            else
                balance = balance - amount;
        }

        public void revision()
        {
            balance = balance + balance * Interest - Comission;
        }

        public override string ToString()
        {
            return "Account{" + 
                    "balance=" + balance +
                    ", owner=" + owner +
                    '}';
        }

        public Customer Owner { get => owner; set => owner = value; }

        public double Interest { get => interest; set => interest = value; }

        public double Comission { get => 1; }
    }
}
