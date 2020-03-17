﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using DecimalBinary_Converter;

namespace methods {
    public class Methods {
        public char[] seperator = { ' ',};
        public char[] perSeperator = { '.' };
        public Int32 count = 99;
        public List<char> hexas = new List<char>();
        public int eightSlot;
        public int fourSlot;
        public int twoSlot;
        public int oneSlot;
        public int biTotal;
        public char switcher;
        public char[] letters = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
        public char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};

        public void ConvToHexa(string binary) {
            char[] seperator = { ' ' };
            Int32 count = 8;
            String[] bits = binary.Split(seperator, count, StringSplitOptions.None);
            List<char> hexas = new List<char>();

            Console.Write("Your hexadecimal is: ");
            foreach (string bit in bits) {
                if (bit[0] == '1')
                {
                    eightSlot = 8;
                }
                else {
                    eightSlot = 0;
                }

                if (bit[1] == '1')
                {
                    fourSlot = 4;
                }
                else
                {
                    fourSlot = 0;
                }

                if (bit[2] == '1')
                {
                    twoSlot = 2;
                }
                else
                {
                    twoSlot = 0;
                }

                if (bit[3] == '1')
                {
                    oneSlot = 1;
                }
                else
                {
                    oneSlot = 0;
                }

                biTotal = eightSlot + fourSlot + twoSlot + oneSlot;

                

                switch (biTotal) {
                    case 10:
                        switcher = 'A';
                        Console.Write(switcher);
                        break;

                    case 11:
                        switcher = 'B';
                        Console.Write(switcher);
                        break;

                    case 12:
                        switcher = 'C';
                        Console.Write(switcher);
                        break;

                    case 13:
                        switcher = 'D';
                        Console.Write(switcher);
                        break;

                    case 14:
                        switcher = 'E';
                        Console.Write(switcher);
                        break;

                    case 15:
                        switcher = 'F';
                        Console.Write(switcher);
                        break;
                    default:
                        Console.Write(biTotal);
                        break;
                }

                hexas.Add(switcher);


            }

            
        }

        public void ConvToBinary(string val, string type) {

            if (type == "hexadecimal" || type == "Hexadecimal" || type == "HEXADECIMAL")
            {
                Dictionary<char, string> d = new Dictionary<char, string> {
                {'A',"1010" },
                {'B',"1011" },
                {'C',"1100" },
                {'D',"1101" },
                {'E',"1110" },
                {'F',"1111" },
                {'a',"1010" },
                {'b',"1011" },
                {'c',"1100" },
                {'d',"1101" },
                {'e',"1110" },
                {'f',"1111" },
                };

                Dictionary<char, string> y = new Dictionary<char, string> {
                {'0',"0000" },
                {'1',"0001" },
                {'2',"0010" },
                {'3',"0011" },
                {'4',"0100" },
                {'5',"0101" },
                {'6',"0110" },
                {'7',"0111" },
                {'8',"1000" },
                {'9',"1001" },
                };

                Console.Write("\nYour binary is: ");

                foreach (char i in val)
                {
                    if (d.ContainsKey(i))
                    {
                        Console.Write(d[i]);
                        Console.Write(" ");
                    }
                    else if (y.ContainsKey(i))
                    {
                        Console.Write(y[i]);
                        Console.Write(" ");
                    }
                }

            }
            else if (type == "decimal" || type == "Decimal" || type == "DECIMAL") {
                String[] octets = val.Split(perSeperator, count, StringSplitOptions.None);
                Console.Write("\nYour binary number is:");

                foreach (string octet in octets) {
                    int value = Convert.ToInt32(octet);
                    string binaryOutput = "0000 0000";
                    StringBuilder bO = new StringBuilder(binaryOutput);

                    while (value > 0)
                    {
                        if (value >= 128)
                        {
                            bO[0] = '1';
                            value -= 128;
                            continue;
                        }
                        else if (value >= 64 && value < 128)
                        {
                            bO[1] = '1';
                            value -= 64;
                            continue;
                        }
                        else if (value >= 32 && value < 64)
                        {
                            bO[2] = '1';
                            value -= 32;
                            continue;
                        }
                        else if (value >= 16 && value < 32)
                        {
                            bO[3] = '1';
                            value -= 16;
                            continue;
                        }
                        else if (value >= 8 && value < 16)
                        {
                            bO[5] = '1';
                            value -= 8;
                            continue;
                        }
                        else if (value >= 4 && value < 8)
                        {
                            bO[6] = '1';
                            value -= 4;
                            continue;
                        }
                        else if (value >= 2 && value < 4)
                        {
                            bO[7] = '1';
                            value -= 2;
                            continue;
                        }
                        else if (value >= 1 && value < 2)
                        {
                            bO[8] = '1';
                            value -= 1;
                            continue;
                        }

                    }

                    Console.Write("\n" + bO);

                }
            }
        }

        public void ConvToDec(string val, string type) {
            Console.WriteLine("Your decimal number is: ");
            if (type == "hexadecimal" || type == "Hexadecimal" || type == "HEXADECIMAL") {
                List<char> hexa = new List<char>();
                List<int> addTogether = new List<int>();

                foreach (char i in val) {
                    hexa.Add(i);
                }
                hexa.Reverse();

                foreach (char i in hexa) {
                    char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                    char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'A', 'B', 'C', 'D', 'E', 'F' };
                    int power = Convert.ToInt32(hexa.IndexOf(i));
                    if (nums.Contains(i))
                    {
                        
                        addTogether.Add(Convert.ToInt32(Convert.ToInt32(i) * Math.Pow(16, hexa.IndexOf(i))));
                    }
                    else if (letters.Contains(i)) {

                        switch (i) {

                            case 'A':
                                addTogether.Add(Convert.ToInt32(10 * Math.Pow(16, power)));
                                break;
                            case 'a':
                                addTogether.Add(Convert.ToInt32(10 * Math.Pow(16, power)));
                                break;
                            case 'B':
                                addTogether.Add(Convert.ToInt32(11 * Math.Pow(16, power)));
                                break;
                            case 'b':
                                addTogether.Add(Convert.ToInt32(11 * Math.Pow(16, power)));
                                break;
                            case 'C':
                                addTogether.Add(Convert.ToInt32(12 * Math.Pow(16, power)));
                                break;
                            case 'c':
                                addTogether.Add(Convert.ToInt32(12 * Math.Pow(16, power)));
                                break;
                            case 'D':
                                addTogether.Add(Convert.ToInt32(13 * Math.Pow(16, power)));
                                break;
                            case 'd':
                                addTogether.Add(Convert.ToInt32(13 * Math.Pow(16, power)));
                                break;
                            case 'E':
                                addTogether.Add(Convert.ToInt32(14 * Math.Pow(16, power)));
                                break;
                            case 'e':
                                addTogether.Add(Convert.ToInt32(14 * Math.Pow(16, power)));
                                break;
                            case 'F':
                                addTogether.Add(Convert.ToInt32(15 * Math.Pow(16, power)));
                                break;
                            case 'f':
                                addTogether.Add(Convert.ToInt32(15 * Math.Pow(16, power)));
                                break;

                            default:
                                break;
                        }
                    }

                }

                int decNum = 0;
                foreach (int i in addTogether) {
                    decNum += i;
                }
                Console.Write(decNum);
                Console.WriteLine("\n");
            }
        }
    }
}