using System;
using System.Collections.Generic;
using System.Text;
using bank;


    [Serializable]
    public class NoMoney : Exception
    {

        public NoMoney(String message)
            : base(message)
        {
        }
    }

