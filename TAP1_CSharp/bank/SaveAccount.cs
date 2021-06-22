using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    public class SaveAccount : Account
    {
        public SaveAccount(int balance, Customer owner) :
                base(balance, owner)
        {
            interest = 0.2;
        }
    }
}
