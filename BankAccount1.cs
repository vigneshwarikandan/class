using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class BankAccount
    {
        string accountNumber = "";
        string accountHolder = "";
        double balance = 0.0;

        public BankAccount(string accountNumber, string accountName, double amount)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountName;
            balance = amount;
        }
        public void WithDraw(double amount)
        {
            if (amount < balance)
            {
                balance = balance - amount;
            }
            else
            {
                Console.WriteLine("The amount to be withdrawn is greater than balance.Enter amount again");
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

        public string AccountName
        {
            set
            {
                accountHolder = value;
            }
            get
            {
                return accountHolder;
            }

        }

        void Deposit(double amount)
        {
            balance = balance + amount;
        }

        void TransferTo(BankAccount bankAccountNumber, double amount)
        {
            this.WithDraw(amount);
            bankAccountNumber.Deposit(amount);
        }

        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("100001", "abc", 2000);
            System.Console.WriteLine("The account1 balance before deposit is ={0}", account1.getBalance());
            account1.Deposit(2000);
            System.Console.WriteLine("The account1 balance after deposit is ={0}", account1.getBalance());
            account1.WithDraw(2000);
            System.Console.WriteLine("The account1 balance after withdraw is ={0}", account1.getBalance());
            account1.WithDraw(3000);
            BankAccount account2 = new BankAccount("100002", "def", 2000);
            System.Console.WriteLine("The account2 balance is ={0}", account2.getBalance());
            account2.TransferTo(account1, 3000);
            System.Console.WriteLine("The account1 balance after fund transfer is ={0}", account1.getBalance());


        }
    }
}
