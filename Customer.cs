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

        public override string ToString()
        {
            return String.Format("Customer[{0},{1},{2}]", customerName, customerAddress, passportNumber);
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
            Customer customer1 = new Customer("samyu", "addr1", "g12343");    
            System.Console.WriteLine("Birth year=" + customer.dob.Year);
            customer.setAge(DateTime.Today.Year- customer.dob.Year);
            System.Console.WriteLine("Age =" + customer.getAge());
            System.Console.WriteLine("Name =" + customer1.getCustomerName());


        }
    }
}
