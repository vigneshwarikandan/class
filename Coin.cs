using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Coin:IInvestment
    {

        public string dateAcquired()
        {            
            return "2014-01-12";
        }
        public double profits()
        {
            return 0;
        }
        public double estimatedValue()
        {
            return 12;
        }
        public double cost()
        {
            return 10;
        }
    }
    public class Gold:IInvestment
    {
        public string dateAcquired()
        {
            return "2015-01-12";
        }
        public double profits()
        {
            return 0;
        }
        public double estimatedValue()
        {
            return 12;
        }
        public double cost()
        {
            return 10;
        }
    }
    public class Antique:IInvestment
    {
        public string dateAcquired()
        {
            return "2016-01-12";
        }
        public double profits()
        {
            return 0;
        }
        public double estimatedValue()
        {
            return 22;
        }
        public double cost()
        {
            return 20;
        }
    }

    //public class Investments
    //{
        
    //    public void addInvestments(IInvestment investment_val)
    //    {

    //    }
    //}
    public class TestInterface
    {
        static void Main(string[] args){
            //Investments investment = new Investments();
            //investment.addInvestments(new Coin());
            IInvestment[] iinvestment = new IInvestment[] {new Coin(),new Gold(),new Antique() };
            foreach (IInvestment invest in iinvestment)
            {
                System.Console.WriteLine("The investment is {0}", invest);
                System.Console.WriteLine("Total value={0}",invest.estimatedValue());
                System.Console.WriteLine("profits={0}", invest.estimatedValue()-invest.cost());

            }
        }
    }
}
