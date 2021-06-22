using System;
using TAP1_CSharp.bank;

namespace bank
{
	public class UseBank
	{
		public static void Main(string[] args)
		{
            Customer c1 = new Customer("1", "pedro");
            Customer c2 = new Customer("2", "pep");
            Customer c3 = new Customer("3", "pau");

            Account a1 = new CheckingAccount(90, c1);
            Account a2 = new SaveAccount(100, c2);
            Account a3 = new InvestFund(10, c3);
            Account a4 = new BonusAccount(10, c3);

            Bank b1 = new Bank("TAP");
            b1.addAccount(a1);
            b1.addAccount(a2);
            b1.addAccount(a3);
            b1.addAccount(a4);

            b1.addCustomer(c1);
            b1.addCustomer(c2);
            b1.addCustomer(c3);

            b1.showAccounts();

            a1.deposit(10);

            try
            {
                a3.Withdraw(1);
            }
            catch (NoMoney e1)
            {
                Console.WriteLine(e1.Message);
            }

            try
            {
                a4.Withdraw(100);
            }
            catch (NoMoney e1)
            {
                Console.WriteLine(e1.Message);
            }

            Console.WriteLine("Before revision:");
            b1.showAccounts();
            b1.revision();
            Console.WriteLine("Before revision:");
            b1.showAccounts();

        }
	}
}
