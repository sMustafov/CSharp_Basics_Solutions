using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] text = input.Split('\\');
            string firstInput = text[0];
            string secondInput = text[1];
            string thirdInput = text[2]; // join; right exclude; left exclude
            int isEqual = 0;
            StringBuilder arr = new StringBuilder();
            int index = 0;
            if (thirdInput == "join")
            {
                for (int i = 0; i < firstInput.Length; i++)
                {
                    for (int j = 0; j < secondInput.Length; j++)
                    {
                        if (firstInput[i] == secondInput[j])
                        {
                            arr.Insert(index, firstInput[i]);
                            index++;
                        }
                    }
                }
            }
            else if (thirdInput == "right exclude")
            {
                for (int i = 0; i < firstInput.Length; i++)
                {
                    isEqual = 0;
                    for (int j = 0; j < secondInput.Length; j++)
                    {
                        if (firstInput[i] == secondInput[j])
                        {
                            isEqual++;
                        }
                    }
                    if (isEqual == 0)
                    {
                        arr.Insert(index,firstInput[i]);
                        index++;
                        //Console.Write(firstInput[i]);
                    }
                }
            }
            else if (thirdInput == "left exclude")
            {
                for (int i = 0; i < secondInput.Length; i++)
                {
                    isEqual = 0;
                    for (int j = 0; j < firstInput.Length; j++)
                    {
                        if (secondInput[i] == firstInput[j])
                        {
                            isEqual++;
                        }
                    }
                    if (isEqual == 0)
                    {
                        arr.Insert(index, secondInput[i]);
                        index++;
                        //Console.Write(secondInput[i]);
                    }
                }
            }
            char[] array = arr.ToString().ToCharArray();
            Array.Sort<char>(array);
            char [] arra = array.Distinct().ToArray();
            for (int a = 0; a < arra.Length; a++ )
            {
                    Console.Write(arra[a]);
            }
        }
    }
}


