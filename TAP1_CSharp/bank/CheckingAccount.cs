using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(double balance, Customer owner) : base(balance, owner)
        {
            interest = 0.1;
        }

        public void revision()
        {
            balance = (balance + (balance * interest));
        }
    }
}
