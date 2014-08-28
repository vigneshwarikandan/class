using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
   public class BankAccount3
    {
        string accountNumber = "";
        Customer accountHolder;
        protected double balance = 0.0;

        public BankAccount3() :this("",  new Customer(),100.0)
        {
        }

        public BankAccount3(string accountNumber, Customer customerName, double amount) 
        {
            this.accountNumber = accountNumber;
            this.accountHolder = customerName;
            balance = amount;
        }
        public bool WithDraw(double amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
                return true;
            }
            else
            {
                Console.WriteLine("balance=" + this.balance + " account name=" + this.accountHolder.getCustomerName());
                Console.WriteLine("The amount to be withdrawn is greater than balance.Enter amount again");
                return false;
            }
        }


        public double getBalance()
        {
            return balance;
        }

        public void SetAccountNumber(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public string getAccountNumber()
        {
            return accountNumber;
        }

        public string AccountHolder
        {
            get
            {
                return accountHolder.getCustomerName();
            }

        }

        public string AccountNumber
        {
            set
            {
                accountNumber = value;
            }
            get
            {
                return accountNumber;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }

        }

        void Deposit(double amount)
        {
            balance = balance + amount;
        }

        void TransferTo(BankAccount3 bankAccountNumber, double amount)
        {
            if (WithDraw(amount))
            {
                bankAccountNumber.Deposit(amount);
            }
        }

        public string Show()
        {
            string m = String.Format
                         ("[Account:accountNumber={0},accountHolder={1},balance={2}]",
                          AccountNumber, AccountHolder, Balance);
            return (m);
        }

        static void Main(string[] args)
        {
            Customer customer1 = new Customer("samyu", "addr1", "1234566");
            BankAccount3 account1 = new BankAccount3("100001", customer1, 2000);
            System.Console.WriteLine("The account1 balance before deposit is ={0}", account1.getBalance());
            account1.Deposit(2000);
            System.Console.WriteLine("The account1 balance after deposit is ={0}", account1.getBalance());
            account1.WithDraw(2000);
            System.Console.WriteLine("The account1 balance after withdraw is ={0}", account1.getBalance());
            //account1.WithDraw(3000);
            System.Console.WriteLine("The account1 customer is " + account1.Show());
            Customer customer2 = new Customer("adi", "addr2", "1234566");
            BankAccount3 account2 = new BankAccount3("100002", customer2, 3000);
            //System.Console.WriteLine("The account2 balance is ={0}", account2.getBalance());

            account2.TransferTo(account1, 3000);
            // System.Console.WriteLine("The account1 balance after fund transfer is ={0}", account1.getBalance());
            System.Console.WriteLine("The account1 customer is " + account1.Show());
            System.Console.WriteLine("The account2 customer is " + account2.Show());

            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.CalculateInterest(account1.getBalance());
            System.Console.WriteLine("The account1 customer is " + account1.Show());

            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.CalculateInterest(account1.getBalance());
            System.Console.WriteLine("The account1 customer is " + account1.Show());

            OverDraft overDraft = new OverDraft();
            overDraft.CalculateInterest(account1.getBalance());
            System.Console.WriteLine("The account1 customer is " + account1.Show());
        }
    }

    class SavingsAccount : BankAccount3
    {
        public void CalculateInterest(double balance)
        {
            balance = balance + balance * 0.01;
        }

        public void CreditInterest()
        {

        }
    }

    class CurrentAccount : BankAccount3
    {
        public void CalculateInterest(double balance)
        {
            balance = balance + balance * 0.25;
        }

        public void CreditInterest()
        {
        }
    }

    class OverDraft : BankAccount3
    {
        public void CalculateInterest(double amount)
        {
            balance = balance + balance * 0.06;
        }

        public void CreditInterest(double amount)
        {
        }

        public void Withdraw(double amount)
        {
        }
    }
}
