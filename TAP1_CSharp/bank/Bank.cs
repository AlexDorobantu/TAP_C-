using System;
using System.Collections.Generic;
using System.Text;
using bank;

namespace TAP1_CSharp.bank
{
    public class Bank
    { 

        private string name;
        private List<Account> accounts = new List<Account>();

        private List<Customer> customers = new List<Customer>();

        public Bank(String name)
        {
            this.name = name;
        }

        public void addAccount(Account newAccount)
        {
            this.accounts.Add(newAccount);
        }

        public void removeAccount(Account oldAccount)
        {
            this.accounts.Remove(oldAccount);
        }

        public List<Account> getAccounts()
        {
            return this.accounts;
        }

        public void addCustomer(Customer newCustomer)
        {
            this.customers.Add(newCustomer);
        }

        public void removeCustomer(Customer oldCustomer)
        {
            this.customers.Remove(oldCustomer);
        }

        public List<Customer> getCustomers()
        {
            return this.customers;
        }

        public void showAccounts()
        {
            foreach (Account a in this.accounts)
            {
                Console.WriteLine(a);
            }

        }

        public void revision()
        {
            foreach (Account acc in this.accounts)
            {
                acc.revision();
            }

        }


    }
}
