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
            CompareCustomer c = new CompareCustomer("Tan Ah Lian", "4 Short Street", 2000);
            CompareCustomer d = new CompareCustomer("Tan Ah Kow", "81 Berry Road", 1500);
            int n = 65;
            int m = 231;
            int[] intArray = new int[] { 90, 20, 24, 10, 80 };
            foreach (int x in intArray) Console.Write("{0} ", x); Console.WriteLine();
            Array.Sort(intArray);
            foreach (int x in intArray) Console.Write("{0} ", x); Console.WriteLine();
            Console.WriteLine(n < m);
            Console.WriteLine(c.CompareTo(d));
            CompareCustomer[] customerArray = new CompareCustomer[] { new CompareCustomer("Tan Ah L", "4 Short Street", 2000),  new CompareCustomer("Tan Ah Kow", "81 Berry Road", 1500) };
            Array.Sort(customerArray);
            foreach (CompareCustomer x in customerArray)
            {
                Console.WriteLine("{0} ", x.Name);                
            }
        }
    }
}