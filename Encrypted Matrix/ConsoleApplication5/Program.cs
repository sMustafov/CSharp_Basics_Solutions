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
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            string result = null ;
            for (int i = 0; i < input.Length; i++)
            {
                int ascii = input[i];
                int lastDigit = ascii % 10;
                result = digits.Insert(i, lastDigit).ToString();
            }
            int number = 0;
            StringBuilder final = new StringBuilder ();
            string finalResult = null;
            int index = 0;
            for (int j = 0; j < result.Length;j++)
            {
                if ((result[j] - '0') % 2 == 0)
                {
                    number = (result[j] - '0') * (result[j] - '0');
                }
                else if ((result[j] - '0') % 2 != 0 && j != 0 && j != (result.Length - 1))
                {
                    number = (result[j] - '0') + (result[j - 1] - '0') + (result[j + 1] - '0');
                }
                else if ((result[j] - '0') % 2 != 0 && j == 0 && input.Length == 1)
                {
                    number = (result[j] - '0') + 0 + 0;
                }
                else if ((result[j] - '0') % 2 != 0 && j == 0)
                {
                    number = (result[j] - '0') + 0 + (result[j + 1]- '0');
                }
                else if ((result[j] - '0') % 2 != 0 && j == (result.Length - 1))
                {
                    number = (result[j] - '0') + 0 + (result[j - 1] - '0');
                }
                if (number > 9)
                {
                    finalResult = final.Insert(index, number).ToString();
                    index+=2;
                }
                else
                {
                    finalResult = final.Insert(index, number).ToString();
                    index++;
                }
            }
            if (command == "\\")
            {
                for (int f = 0; f < finalResult.Length; f++)
                {
                    for (int s = 0; s < finalResult.Length; s++)
                    {
                        if (f == s)
                        {
                            Console.Write(finalResult[f] + " ");
                        }
                        else
                        {
                            Console.Write("0" + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (command == "/")
            {
                int lett = finalResult.Length - 1;
                for (int f = 0; f < finalResult.Length; f++)
                {
                    for (int s = finalResult.Length - 1; s >= 0; s--)
                    {
                        if (f == s)
                        {
                            Console.Write(finalResult[lett] + " ");
                            lett--;
                        }
                        else
                        {
                            Console.Write("0" + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
