using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
   public class Customer
    {
        string customerName;
        string customerAddress = "";
        string passportNumber = "";
        DateTime dob;
        int age;
        public Customer()
        {
        }
        public Customer(string customerName, string customerAddress,string passportNumber)
        {
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.passportNumber = passportNumber;

        }

        public Customer(int year, int month, int date)
        {
            dob = new DateTime(1986, 08, 31);
        }
        void setAge(int age)
        {
            this.age = age; 
        }

        int getAge()
        {
            return age;
        }

        public string getCustomerName()
        {
            return customerName;
        }

        static void Main(string[] args)
        {
            Customer customer = new Customer(1986,08,31);           
            System.Console.WriteLine("Birth year=" + customer.dob.Year);
            customer.setAge(DateTime.Today.Year- customer.dob.Year);
            System.Console.WriteLine("Age =" + customer.getAge());

        }
    }
}
