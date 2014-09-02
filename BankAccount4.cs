using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace day1
{
    public class BankAccount4
    {
        string accountNumber = "";
        Customer accountHolder;
        protected double balance = 0.0;

        public BankAccount4()
            : this("", new Customer(), 100.0)
        {
        }

        public BankAccount4(string accountNumber, Customer customerName, double amount)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = customerName;
            balance = amount;
        }

        public override string ToString()
        {
            return String.Format("BankAccount[{0},{1},{2}]", accountNumber, accountHolder.getCustomerName(), balance);
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
        public virtual double CalculateInterest()
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

        //public void SetAccountNumber(string accountNumber)
        //{
        //    this.accountNumber = accountNumber;
        //}

        //public string getAccountNumber()
        //{
        //    return accountNumber;
        //}

        public Customer AccountHolder
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

        void TransferTo(BankAccount4 bankAccountNumber, double amount)
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
            BankAccount4 account1 = new BankAccount4("100001", customer1, 2000);

            account1.Deposit(2000);

            account1.WithDraw(2000);

            System.Console.WriteLine("The account1 customer is " + account1.Show());
            Customer customer2 = new Customer("adi", "addr2", "1234566");
            BankAccount4 account2 = new BankAccount4("100002", customer2, 3000);
            account2.TransferTo(account1, 3000);
            System.Console.WriteLine("The account2 customer is " + account2.Show());

            account1.CreditInterest(account1.CalculateInterest());
            System.Console.WriteLine("The account1 customer in savings accountis " + account1.Show());

            CurrentAccounts currentAccount = new CurrentAccounts("100001", customer1, 2000);
            currentAccount.CreditInterest(currentAccount.CalculateInterest());
            System.Console.WriteLine("The account1 customer is " + currentAccount.Show());

            OverDrafts overDraft = new OverDrafts("100001", customer1, 2000);
            overDraft.WithDraw(2000);
            overDraft.WithDraw(2000);
            overDraft.WithDraw(2000);
            overDraft.WithDraw(2000);
            overDraft.CreditInterest(overDraft.CalculateInterest());
            System.Console.WriteLine("The account1 customer is " + overDraft.Show());
        }
    }



    class CurrentAccounts : BankAccount4
    {
        public CurrentAccounts(string accountNumber, Customer customerName, double amount)
            : base(accountNumber, customerName, amount)
        {

        }
        public override double CalculateInterest()
        {
            Console.WriteLine("Inside credit interest " + getBalance());
            return (0.25 * getBalance()) / 100;
        }
    }

    class OverDrafts : BankAccount4
    {
        static double interest_rate = 0.25;
        static int overDraft_interest = 6;

        public OverDrafts(string accountNumber, Customer customerName, double amount)
            : base(accountNumber, customerName, amount)
        {

        }

        public override double CalculateInterest()
        {
            if (balance > 0)
            {
                return (getBalance() * interest_rate) / 100;
            }
            else
            {
                Console.WriteLine("Inside overdraft interest " + getBalance());
                return (overDraft_interest * getBalance()) / 100;
            }
        }

        public new void WithDraw(double amount)
        {
            Console.WriteLine("Inside overdraft");
            balance = balance - amount;
        }
    }

    class BankBranch
    {
        string BranchName;
        string BranchManager;
        ArrayList BankAccounts;

        public BankBranch(string BranchName,string BranchManager)
        {
            this.BranchName = BranchName;
            this.BranchManager = BranchManager;
            BankAccounts=new ArrayList();
        }


        public void AddAccount(BankAccount4 bankAccount)
        {
            BankAccounts.Add(bankAccount);
        }

        public void PrintCustomers()
        {
            ArrayList customers = new ArrayList();
            System.Console.WriteLine("Inside bank branch " + BankAccounts.Count);
            for (int i = 0; i < BankAccounts.Count; i++)
            {                
                BankAccount4 accounts=(BankAccount4)BankAccounts[i];
                Customer cust = accounts.AccountHolder;
                int customerIndex = customers.IndexOf(cust);
                if (customerIndex < 0)
                {
                    customers.Add(cust);
                }
            }
            for (int j = 0; j < customers.Count; j++)
            {
                Customer cus =(Customer) customers[j];
                System.Console.WriteLine("Print customers " + cus);
            }
        }

        public double TotalDeposits()
        {
            double Bankbalance = 0 ;
            for (int i = 0; i < BankAccounts.Count; i++)
            {
                BankAccount4 bankAccount=(BankAccount4)BankAccounts[i];
                double bal=bankAccount.Balance;
                if ( bal> 0)
                {
                    Bankbalance = Bankbalance + bal;
                }                
            }
            return Bankbalance;
        }

        public double TotalInterestPaid()
        {
            double total_interest = 0;
            for (int i = 0; i < BankAccounts.Count; i++)
            {
                BankAccount4 bankAccount = (BankAccount4)BankAccounts[i];
                double intr=bankAccount.CalculateInterest();
                if (intr > 0)
                {
                    total_interest += intr;
                }
            }
            return total_interest;
        }

        public double TotalInterestEarn()
        {
            double totalInterestEarned = 0;
            for (int i = 0; i < BankAccounts.Count; i++)
            {
                BankAccount4 bankAccount = (BankAccount4)BankAccounts[i];
                Console.WriteLine("TotalInterestEarn {0}", bankAccount);
                double intrEarned = bankAccount.CalculateInterest();
                if (intrEarned < 0)
                {
                    totalInterestEarned = totalInterestEarned + (-intrEarned);
                }
            }
            return totalInterestEarned;
        }

        static void Main(string[] args)
        {
            Customer[] list = new Customer[3];

            Customer customer1 = new Customer("adi", "addr2", "1234566");
            Customer customer2 = new Customer("samyu", "addr1", "1234566");
            Customer customer3 = new Customer("xx","add3","12332");

            list[0] = customer1;
            list[1] = customer2;
            list[2] = customer3;

            BankBranch bankBranch = new BankBranch("K.K. Nagar Branch","Tim lee");
            bankBranch.AddAccount(new CurrentAccounts("123456",customer1,200.02));
            bankBranch.AddAccount(new CurrentAccounts("456789",customer2,400.02));
            bankBranch.AddAccount(new OverDrafts("1234586",customer3,-5000));
            bankBranch.PrintCustomers();
            System.Console.WriteLine("Deposits={0}",bankBranch.TotalDeposits());
            System.Console.WriteLine("Total interest paid={0}",bankBranch.TotalInterestPaid());
            System.Console.WriteLine("Total interest earned={0}",bankBranch.TotalInterestEarn());            
        }
    }
}
