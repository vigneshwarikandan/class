using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Ex40
    {
        static void convertSingle(int decNum)
        {
            int number = decNum;
            string hexdec = "";
            string original_hexdec = "";
            int q = number;
            int r = 0;
            while (q >16)
            {                
                r = q % 16;
                Console.WriteLine("rem={0}",r);
                q = q / 16;
                Console.WriteLine("q={0}", q);
                if (r > 9)
                {
                    switch (r)
                    {
                        case 10:
                            r = 65;
                            break;
                        case 11:
                            r = 66;
                            break;
                        case 12:
                            r = 67;
                            break;
                        case 13:
                            r = 68;
                            break;
                        case 14:
                            r = 69;
                            break;
                        case 15:
                            r = 70;
                            break;
                    }
                    hexdec = hexdec +(char)r;
                }
                else
                {
                    hexdec = hexdec + r;
                }
                if (q < 16)
                {
                    hexdec = hexdec + q;
                }
                
            }
            
            for (int i = hexdec.Length-1; i >= 0; i--)
            {
                original_hexdec = original_hexdec + hexdec.ElementAt(i);
            }
            Console.WriteLine("hexdec=" + original_hexdec);

        }
        static void Main(string[] args)
        {
            convertSingle(317547);
            convertDecToHex();
        }

        static void convertDecToHex()
        {
            for (int i = 1; i <= 100; i++)
            {
                string hexdec = "";
                string original_hexdec = "";
                int q = i;
                int r = 0;
                while (q > 16)
                {
                    r = q % 16;                    
                    q = q / 16;                   
                    if (r > 9)
                    {
                        switch (r)
                        {
                            case 10:
                                r = 65;
                                break;
                            case 11:
                                r = 66;
                                break;
                            case 12:
                                r = 67;
                                break;
                            case 13:
                                r = 68;
                                break;
                            case 14:
                                r = 69;
                                break;
                            case 15:
                                r = 70;
                                break;
                        }
                        hexdec = hexdec + (char)r;
                    }
                    else
                    {
                        hexdec = hexdec + r;
                    }
                    if (q < 16)
                    {
                        hexdec = hexdec + q;
                    }

                }

                for (int j = hexdec.Length - 1; j >= 0; j--)
                {
                    original_hexdec = original_hexdec + hexdec.ElementAt(j);
                }
                System.Console.WriteLine("The hex dec value of {0} is {1}", i, original_hexdec);
            }
        }

    }
}
