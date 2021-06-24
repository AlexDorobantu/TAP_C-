using System;
using System.Collections.Generic;
using System.Text;

namespace accounts
{
    public class Account
    {

        private string id;
        private string name;
        private AccType type;
        private double balance;

        public Account(string id, string name, AccType type, double balance)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.balance = balance;
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public AccType GetType()
        {
            return this.type;
        }

        public Account(string id, string name, string type, double balance)
        {
            this.id = id;
            this.name = name;
            // this.type = type;
            this.balance = balance;

            switch (this.type)
            {
                case AccType.IF:
                    this.type = AccType.IF;
                    break;
                case AccType.CA:
                    this.type = AccType.CA;
                    break;
                case AccType.SA:
                    this.type = AccType.SA;
                    break;
                case AccType.BA:
                    this.type = AccType.BA;
                    break;
            }
        }

        public void deposit(double money)
        {
            this.balance = (this.balance + money);
        }

        public String ToString()
        {
            return ("Account{" + 
                "name='" + this.name + '\\' +
                ", balance=" + this.balance + 
                ", type=" + this.type + '}');
        }
    }
}
