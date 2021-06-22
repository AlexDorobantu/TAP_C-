using System;
using System.Collections.Generic;
using System.Text;
using bank;

namespace bank
{
    public class InvestFund : Account
    {
        private double amount;

        public InvestFund(int balance, Customer owner) : base(balance, owner)
        {
            interest = 0.34;
        }

        public new void Withdraw(double amount)
        {
            throw new NoMoney("InvestFound is locked");
        }
    }
}
