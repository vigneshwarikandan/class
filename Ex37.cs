using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Ex37
    {
        static void ChangeTitleCase1(string[] args)
        {
            string s = "institute of system science";
            string newString = "";

            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string newWords = "";
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (j == 0)
                    {
                        newWords = newWords + words[i].ElementAt(j);
                        newWords = newWords.ToUpper();
                    }
                    else
                    {
                        newWords = newWords + words[i].ElementAt(j);
                    }
                }
                newString = newString + " " + newWords;
            }

            System.Console.WriteLine("the new string is {0}", newString);
        }

        static void ChangeTitleCase2()
        {
            string s = "institute of system science";
            string newString = "";

            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string newWords = "";
                for (int j = 0; j < words[i].Length; j++)
                {
                     newWords = words[i].Substring(0, 1).ToUpper();
                     newWords = newWords+words[i].Substring(1, words[i].Length - 1).ToLower();                     
                }
                newString = newString + " " + newWords;
            }

            System.Console.WriteLine("the new string is {0}", newString);
        }

        static void Main(string[] args)
        {
            ChangeTitleCase2();
        }
    }
}
