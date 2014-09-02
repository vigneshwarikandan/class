using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Coin:IInvestment
    {
        string dateAcquired_var;
        double profits_var;
        double estimatedValue_var;
        double cost_var;
        public Coin(string dateAcquired,double profits,double estimatedValue,double cost)
        {
            this.dateAcquired_var = dateAcquired;
            this.profits_var = profits;
            this.estimatedValue_var = estimatedValue;
            this.cost_var = cost;
        }
        public string dateAcquired()
        {
            return dateAcquired_var;
        }
        public double profits()
        {
            return estimatedValue()-cost();
        }
        public double estimatedValue()
        {
            return estimatedValue_var;
        }
        public double cost()
        {
            return cost_var;
        }
    }
    public class Gold:IInvestment
    {
        string dateAcquired_var;
        double profits_var;
        double estimatedValue_var;
        double cost_var;
        public Gold(string dateAcquired, double profits, double estimatedValue, double cost)
        {
            this.dateAcquired_var = dateAcquired;
            this.profits_var = profits;
            this.estimatedValue_var = estimatedValue;
            this.cost_var = cost;
        }
        public string dateAcquired()
        {
            return dateAcquired_var;
        }
        public double profits()
        {
            return estimatedValue()-cost();
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
        string dateAcquired_var;
        double profits_var;
        double estimatedValue_var;
        double cost_var;
        public Antique(string dateAcquired, double profits, double estimatedValue, double cost)
        {
            this.dateAcquired_var = dateAcquired;
            this.profits_var = profits;
            this.estimatedValue_var = estimatedValue;
            this.cost_var = cost;
        }
        public string dateAcquired()
        {
            return dateAcquired_var;
        }
        public double profits()
        {
            return estimatedValue()-cost();
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
            IInvestment[] iinvestment = new IInvestment[] {new Coin("2014-02-01",0,12,10),new Gold("2015-02-01",0,22,20),new Antique("2015-02-01",0,32,30) };
            foreach (IInvestment invest in iinvestment)
            {
                System.Console.WriteLine("The investment is {0}", invest);
                System.Console.WriteLine("Total value={0}",invest.estimatedValue());
                System.Console.WriteLine("profits={0}", invest.profits());

            }
        }
    }
}
