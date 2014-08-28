using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Bank
    {
        string accountNumber = "";
        Customer accountHolder ;
        double balance = 0.0;

        public Bank(string accountNumber, Customer customerName, double amount)
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
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }

        }

        void Deposit(double amount)
        {
            balance = balance + amount;
        }

        void TransferTo(Bank bankAccountNumber, double amount)
        {
            if (WithDraw(amount))
            {
                bankAccountNumber.Deposit(amount);
            }
        }

        public string Show() {
            string m = String.Format
                         ("[Account:accountNumber={0},accountHolder={1},balance={2}]",
                          AccountNumber, AccountHolder, Balance);
            return (m);
        }
    
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("samyu","addr1","1234566");
            Bank account1 = new Bank("100001", customer1, 2000);
            System.Console.WriteLine("The account1 balance before deposit is ={0}", account1.getBalance());
            account1.Deposit(2000);
            System.Console.WriteLine("The account1 balance after deposit is ={0}", account1.getBalance());
            account1.WithDraw(2000);
            System.Console.WriteLine("The account1 balance after withdraw is ={0}", account1.getBalance());
            //account1.WithDraw(3000);
            System.Console.WriteLine("The account1 customer is " + account1.Show());
            Customer customer2 = new Customer("adi", "addr2", "1234566");
            Bank account2 = new Bank("100002", customer2, 3000);
            //System.Console.WriteLine("The account2 balance is ={0}", account2.getBalance());
            
            account2.TransferTo(account1, 3000);
           // System.Console.WriteLine("The account1 balance after fund transfer is ={0}", account1.getBalance());
            System.Console.WriteLine("The account1 customer is " + account1.Show());
            System.Console.WriteLine("The account2 customer is " + account2.Show());


        }
    }
}
