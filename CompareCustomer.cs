using System;

namespace Testing
{

    class CompareCustomer :IComparable
    {
        private string name;
        private string address;
        private double balance;

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
        public double Balance
        {
            get
            {
                return balance;
            }
        }
        public CompareCustomer(string n, string a, double b)
        {
            name = n;
            address = a;
            balance = b;
        }

        public int CompareTo(Object obj2){
            if (obj2 is CompareCustomer)
            {
                CompareCustomer c2 = (CompareCustomer)obj2;
                return name.CompareTo(c2.name);
            }
            else
            {
                return -1;
            }
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            CompareCustomer c = new CompareCustomer("Tan Ah L", "4 Short Street", 2000);
            CompareCustomer d = new CompareCustomer("Tan Ah Kow", "81 Berry Road", 1500);
            int n = 65;
            int m = 231;
            Console.WriteLine(n < m);
            Console.WriteLine(c.CompareTo(d));
        }
    }
}