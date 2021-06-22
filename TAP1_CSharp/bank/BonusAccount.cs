using System;
using System.Collections.Generic;
using System.Text;
using bank;

namespace bank
{
    public class BonusAccount : Account
    {
        public BonusAccount(int balance, Customer owner) : base(balance, owner)
        {
            interest = 0.6;
        }
    }
}
