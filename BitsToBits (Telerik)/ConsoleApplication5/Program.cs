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
            int n = int.Parse(Console.ReadLine());
            int ones = 1;
            int zeroes = 1;
            int maxOnes = 0;
            int maxZeroes = 0;
            StringBuilder bin = new StringBuilder ();
            int ind = 0;
            for (int i = 0; i < n ; i++)
            {
                
                int number = int.Parse(Console.ReadLine());
                string binary = Convert.ToString(number, 2).PadLeft(30, '0');
                bin.Insert(ind, binary);
                ind += 30;
            }
                for (int j = 0; j < bin.Length; j++)
                {
                    if (bin[j] == '1' && j != bin.Length - 1)
                    {
                        if (bin[j] == '1' && bin[j + 1] == '1')
                        {
                            ones++;
                        }
                    }
                    if (bin[j] == '1' && j != bin.Length - 1)
                    {
                        if (bin[j] == '1' && bin[j + 1] != '1')
                        {
                            if (ones > maxOnes)
                            {
                                maxOnes = ones;
                            } 
                            ones = 1;
                        }
                       
                    }
                    if (bin[j] == '1' && j == bin.Length - 1)
                    {
                        if (ones > maxOnes)
                        {
                            maxOnes = ones;
                        }
                        ones = 1;
                    }




                    if (bin[j] == '0' && j != bin.Length - 1)
                    {
                        if (bin[j] == '0' && bin[j + 1] == '0')
                        {
                            zeroes++;
                        }
                    }
                    if (bin[j] == '0' && j != bin.Length - 1)
                    {
                        if (bin[j] == '0' && bin[j + 1] != '0')
                        {
                            if (zeroes > maxZeroes)
                            {
                                maxZeroes = zeroes;
                            }
                            zeroes = 1;
                        }
                        
                    }
                    if (bin[j] == '0' && j == bin.Length - 1)
                    {
                        if (zeroes > maxZeroes)
                        {
                            maxZeroes = zeroes;
                        }
                        zeroes = 1;
                    }
                }
            
            Console.WriteLine(maxZeroes);
            Console.WriteLine(maxOnes);
        }
    }
}
