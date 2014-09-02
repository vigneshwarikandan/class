﻿using System;
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
        public double CalculateInterest()
        {
            Console.WriteLine("The  balance from calculate interest=" + getBalance());
            return (1 * getBalance()) / 100;
        }

        public void CreditInterest(double balance_Amount)
        {
            Console.WriteLine("The interest =" + balance_Amount);
            Deposit(balance_Amount);
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
            
            account1.Deposit(2000);
           
            account1.WithDraw(2000);
           
            System.Console.WriteLine("The account1 customer is " + account1.Show());
            Customer customer2 = new Customer("adi", "addr2", "1234566");
            BankAccount3 account2 = new BankAccount3("100002", customer2, 3000);
            account2.TransferTo(account1, 3000);
            System.Console.WriteLine("The account2 customer is " + account2.Show());
            
            account1.CreditInterest(account1.CalculateInterest());
            System.Console.WriteLine("The account1 customer in savings accountis " + account1.Show());

            CurrentAccount currentAccount = new CurrentAccount("100001", customer1, 2000);
            currentAccount.CreditInterest(currentAccount.CalculateInterest(currentAccount.Balance));
            System.Console.WriteLine("The account1 customer is " + currentAccount.Show());

            OverDraft overDraft = new OverDraft("100001", customer1, 2000);
            overDraft.WithDraw(2000);
            overDraft.WithDraw(2000);
            overDraft.WithDraw(2000);
            overDraft.WithDraw(2000);
            overDraft.CreditInterest(overDraft.CalculateInterest());
            System.Console.WriteLine("The account1 customer is " + overDraft.Show());
        }
    }

    

    class CurrentAccount : BankAccount3
    {
        public CurrentAccount(string accountNumber, Customer customerName, double amount)
            : base("100001", new Customer(), 2000)
        {

        }
        public new double CalculateInterest(double balance_Amount)
        {
            Console.WriteLine("Inside credit interest "+balance_Amount);
            return (0.25 * balance_Amount) / 100;
        }

       
    }

    class OverDraft : BankAccount3
    {
        static double interest_rate = 0.25;
        static int overDraft_interest = 6;

        public OverDraft(string accountNumber, Customer customerName, double amount)
            : base(accountNumber, new Customer(), 2000)
        {

        }

        public new double CalculateInterest()
        {
            if (balance > 0)
            {
                return (balance * interest_rate) / 100;
            }
            else
            {
                Console.WriteLine("Inside overdraft interest " + balance);
                return (overDraft_interest * balance) / 100;
            }
        }



        public new void WithDraw(double amount)
        {
            Console.WriteLine("Inside overdraft");
                balance = balance - amount;            
        }
    }

    
}
