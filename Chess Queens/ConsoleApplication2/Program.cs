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
            int d = int.Parse(Console.ReadLine());

            int lastNum = '`' + n;
            char lastLetter = (char)lastNum;

            int count = 0;
            
            for (char firstLetter = 'a'; firstLetter <= lastLetter; firstLetter++)
            {
                for (int firstNum = 1; firstNum <= n; firstNum++)
                {
                    for (int secondLetter = 'a'; secondLetter <= lastLetter; secondLetter++ )
                    {
                        for (int secondNum = 1; secondNum <= n; secondNum++)
                        {
                            if (firstLetter == secondLetter && secondNum - firstNum == d + 1)
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", (char)firstLetter, firstNum, (char)secondLetter, secondNum);
                                count++;
                            }
                            if (firstNum == secondNum && secondLetter - firstLetter == d + 1)
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", (char)firstLetter, firstNum, (char)secondLetter, secondNum);
                                count++;
                            }
                            if (firstLetter == secondLetter && firstNum - secondNum == d + 1)
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", (char)firstLetter, firstNum, (char)secondLetter, secondNum);
                                count++;
                            }
                            if (firstNum == secondNum && firstLetter - secondLetter == d + 1)
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", (char)firstLetter, firstNum, (char)secondLetter, secondNum);
                                count++;
                            }
                            if (firstLetter - secondLetter == d + 1 && firstNum - secondNum == d + 1)
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", (char)firstLetter, firstNum, (char)secondLetter, secondNum);
                                count++;
                            }
                            if (secondLetter - firstLetter == d + 1 && secondNum - firstNum == d + 1)
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", (char)firstLetter, firstNum, (char)secondLetter, secondNum);
                                count++;
                            }
                            if (firstLetter - secondLetter == d + 1 && secondNum - firstNum == d + 1)
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", (char)firstLetter, firstNum, (char)secondLetter, secondNum);
                                count++;
                            }
                            if (secondLetter - firstLetter == d + 1 && firstNum - secondNum == d + 1)
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", (char)firstLetter, firstNum, (char)secondLetter, secondNum);
                                count++;
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No valid positions");
            }
        }
    }
}
