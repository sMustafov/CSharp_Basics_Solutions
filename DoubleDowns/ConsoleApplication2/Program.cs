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

            int vertical = 0;
            int rightDiagonal = 0;
            int leftDiagonal = 0;

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers[i] = num;
            }

            int first = 0;
            int firstBitValue = 0;
            int second = 0;
            int secondBitValue = 0;
            int maxCount = 0;

            for (int j = 0; j < n; j++)
            {
                first = numbers[j];
                string firstBin = Convert.ToString(first, 2);
                maxCount = firstBin.Length;
                if (j + 1 == n)
                {
                    break;
                }
                second = numbers[j + 1];
                string secondBin = Convert.ToString(second, 2);
                if (maxCount < secondBin.Length)
                {
                    maxCount = secondBin.Length;
                }
                for (int k = 0; k < maxCount; k++)
                {
                    firstBitValue = first & (1 << k);
                    firstBitValue = firstBitValue >> k;
                    for (int p = 0; p < maxCount; p++)
                    {
                        secondBitValue = second & (1 << p);
                        secondBitValue = secondBitValue >> p;
                        if (firstBitValue == 1 && secondBitValue == 1)
                        {
                            if (k == p)
                            {
                                vertical++;
                            }
                            else if (k == p + 1)
                            {
                                rightDiagonal++;
                            }
                            else if (k == p - 1)
                            {
                                leftDiagonal++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(rightDiagonal);
            Console.WriteLine(leftDiagonal);
            Console.WriteLine(vertical);
        }
    }
}
