using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            int[] counts = new int[n];

            int count = 0;

            int f = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                string bin = Convert.ToString(num, 2);
                count = bin.Length;

                numbers[f] = num;
                counts[f] = count;
                f++;
            }
            int bitCounts = 0;
            int l = int.Parse(Console.ReadLine());
            for (int k = 0; k < n; k++)
            {
                
                for (int j = 0; j < 2 * counts[k] - 1; j += 2)
                {
                    int max = 2 * counts[k] - 1;
                    if (max < counts[k])
                    {
                        max = counts[k];
                    }
                    string b = Convert.ToString(l, 2).PadRight(max, '0');
                    int bitValue = l & (1 << j);
                    if (bitValue == 0)
                    {
                        bitCounts++;
                    }
                    l = l | (1 << j);
                }
                
            }
            Console.WriteLine(l);
            Console.WriteLine(bitCounts);
        }
    }
}
