using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            string bin = Convert.ToString(num, 2);
            string command = Console.ReadLine();

            long bit = 0;
            long value = 0;
            int index1 = 0;
            int indexForBit = 0;
            long rememberedNum = num;
            while (command != "Game Over!")
            {
                if (command == "Odd")
                {
                    for (int i = bin.Length ; i >= 0 ; i--)
                    {
                        
                        if (index1 % 2 == 0)
                        {
                            bit = num & (1 << index1);
                            bit = bit >> index1;
                            value = value | (bit << indexForBit);
                            indexForBit++;
                        }
                        else
                        {
                        }
                        index1++;
                    }
                    rememberedNum = value;
                    num = value;
                    bin = Convert.ToString(num, 2);
                    index1 = 0;
                    indexForBit = 0;
                    value = 0;
                }
                else if (command == "Even")
                {
                    for (int j = bin.Length; j >= 0; j--)
                    {
                        if (index1 % 2 != 0)
                        {
                            bit = num & (1 << index1);
                            bit = bit >> index1;
                            value = value | (bit << indexForBit);
                            indexForBit++;
                        }
                        else
                        {
                        }
                        index1++;
                    }
                    rememberedNum = value;
                    num = value;
                    bin = Convert.ToString(num, 2);
                    index1 = 0;
                    indexForBit = 0;
                    value = 0;
                }
                command = Console.ReadLine();
            } 

            string binary = Convert.ToString(rememberedNum, 2);
            int numberOfOnes = 0;

            for (int p = 0; p < binary.Length; p++)
            {
                if (binary[p] == '1')
                {
                    numberOfOnes++;
                }
            }
            Console.WriteLine("{0} -> {1}",rememberedNum,numberOfOnes);
        }
    }
}
