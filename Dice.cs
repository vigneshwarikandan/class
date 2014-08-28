using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Dice
    {
        private int faceUP;

        public Dice()
        {
            throwDice();
        }

        public void throwDice()
        {
            faceUP = ISSMath.RNDInt(6)+1;
        }

        public int getFaceUP()
        {
            return faceUP;
        }

        public string strFaceUP
        {
            get
            {
                if (getFaceUP() == 1)
                {
                    return "One";
                }
                else if (getFaceUP() == 2)
                {
                    return "Two";
                }
                else if (getFaceUP() == 3)
                {
                    return "Three";
                }
                else if (getFaceUP() == 4)
                {
                    return "Four";
                }
                else if (getFaceUP() == 5)
                {
                    return "Five";
                }
                else if (getFaceUP() == 6)
                {
                    return "Six";
                }
                else if (getFaceUP() == 7)
                {
                    return "Seven";
                }
                else
                {
                    return "Eight";
                }

            }
        }

        //static double findProbability(int numberOfWays)
        //{
        //    double probability = numberOfWays / 36;
        //    Console.WriteLine("numberOfWays=" + numberOfWays);
        //    Console.WriteLine("probability=" + probability);
        //    return probability;
        //}

        static void findProbability()
        {
            double count = 0;
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    if (i + j == 8)
                    {
                        Console.WriteLine("The faces in dice1=" + i + " and in dice2=" + j);
                        ++count;

                    }
                }
            }
            Console.WriteLine("The probability={0}",count/36);
        }

        public static void Main(string[] args)
        {
            int count = 0;
            int possible_outcomes = 0;
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            while (possible_outcomes <= 100000)
            {
                dice1.throwDice();
                dice2.throwDice();
                 int dice1_face = dice1.getFaceUP();
                int dice2_face = dice2.getFaceUP();


                if (dice1_face + dice2_face == 8)
                {
                    // Console.WriteLine("The faces in dice1=" + dice1.strFaceUP + " and in dice2=" + dice2.strFaceUP);
                    ++count;

                }
                ++possible_outcomes;

            }

            System.Console.WriteLine("The probability =" + ((double)count) / possible_outcomes);
            //Dice dice = new Dice();
            findProbability();

        }
    }
}
