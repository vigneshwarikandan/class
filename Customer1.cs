using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;

namespace Testing
{
    //ToString is defeined in Object class
    //It is defined for int 
    class Customer1
    {
        private string name;
        private string address;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
        }
        public Customer1(string n, string a)
        {
            name = n;
            address = a;
        }

        public String ToString()
        {
            return String.Format("The name is {0} and address is {1}", Name, Address);
        }
    }

    class MainClass1
    {
        public static void Main(string[] args)
        {
            Customer1 c = new Customer1("Tan Ah Kow", "4 Short Street");
            int n = 65;
            Console.WriteLine(n);
            Console.WriteLine(c);
            Console.WriteLine(n.ToString());
            Console.WriteLine(c.ToString());
        }
    }
}
